using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace PixelForge.Characters3D
{
    /// <summary>
    /// Shows a rigged 3D model inside the 2D world as live pixel art.
    ///
    /// How it works: the model is spawned on a private "stage" far away from the world, where a
    /// dedicated orthographic camera renders it into a tiny RenderTexture (e.g. 64x64, point
    /// filtered). That texture is drawn on a quad sitting at this GameObject's position, inside a
    /// SortingGroup, so it Y-sorts against tiles and sprites exactly like a SpriteRenderer would.
    /// With PPU 32 one texel of the render = one pixel of the tileset, so the result has the same
    /// pixel grid as the rest of the art.
    ///
    /// This component is presentation only: it never moves the character. Whoever moves it
    /// (input, AI) reports the motion through SetMotion() and asks for one-shots via PlayAction().
    /// </summary>
    [DisallowMultipleComponent]
    public class PixelModelView : MonoBehaviour
    {
        private const float StageY = -5000f;          // far below any world content
        private const float StageSpacing = 25f;       // between stages, so cameras never see a neighbour
        private const float StageCameraDistance = 10f;
        private const float AnimationPadding = 1.15f; // headroom for swings/jumps beyond the bind pose

        [SerializeField] private Character3DData data;

        [Header("World integration")]
        [Tooltip("Must match the Pixel Perfect Camera's Assets PPU.")]
        [SerializeField] private int pixelsPerUnit = 32;
        [SerializeField] private string sortingLayerName = "Objects";
        [SerializeField] private int sortingOrder = 3;

        [Header("Look")]
        [SerializeField] private Shader toonShader;
        [SerializeField] private Shader displayShader;
        [SerializeField] private Color outlineColor = new Color(0.08f, 0.06f, 0.1f, 1f);
        [Tooltip("Degrees per second when facingDirections is 0 (free rotation).")]
        [SerializeField] private float turnSpeed = 720f;

        public Character3DData Data => data;
        public bool IsPlayingAction => _animation != null && _animation.IsPlayingAction;

        private static readonly List<bool> s_StageSlots = new List<bool>();
        private static Mesh s_QuadMesh;
        private static int s_ForwardRendererIndex = int.MinValue;

        private int _stageSlot = -1;
        private GameObject _stageRoot;
        private Transform _yawPivot;
        private Camera _stageCamera;
        private RenderTexture _renderTexture;
        private Transform _display;
        private Vector3 _displayLocalOffset;
        private readonly List<Material> _ownedMaterials = new List<Material>();
        private ModelAnimationGraph _animation;

        private float _currentYaw = 180f; // facing the camera ("down")
        private float _targetYaw = 180f;

        private void Awake()
        {
            if (data != null) Build(data);
        }

        /// <summary>Builds (or rebuilds) the character from a data asset. Safe to call at runtime.</summary>
        public void Build(Character3DData characterData)
        {
            Teardown();
            data = characterData;
            if (data == null || data.modelPrefab == null)
            {
                Debug.LogError($"[{name}] PixelModelView needs a Character3DData with a modelPrefab.", this);
                return;
            }

            BuildStage();
            Animator animator = SpawnModel();
            BuildCamera(out int originRow);
            BuildDisplay(originRow);
            EnsureSortingGroup();

            if (animator != null) _animation = new ModelAnimationGraph(animator, data);
            ApplyYaw(_currentYaw);
        }

        /// <summary>Report the character's current ground velocity (world units/s, XY plane).</summary>
        public void SetMotion(Vector2 velocity)
        {
            _animation?.SetSpeed(velocity.magnitude);
            if (velocity.sqrMagnitude > 0.0025f) SetFacing(velocity);
        }

        /// <summary>Turns the model toward a 2D direction (+Y = north/away from the camera).</summary>
        public void SetFacing(Vector2 direction)
        {
            if (direction.sqrMagnitude < 0.0001f) return;
            float yaw = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
            if (data != null && data.facingDirections > 0)
            {
                float step = 360f / data.facingDirections;
                yaw = Mathf.Round(yaw / step) * step;
            }
            _targetYaw = yaw;
        }

        /// <summary>Plays a one-shot clip. Returns false when the clip is missing.</summary>
        public bool PlayAction(AnimationClip clip, Action onFinished = null)
        {
            return _animation != null && _animation.PlayAction(clip, onFinished);
        }

        private void LateUpdate()
        {
            if (_stageRoot == null) return;

            bool snapped = data.facingDirections > 0;
            _currentYaw = snapped
                ? _targetYaw
                : Mathf.MoveTowardsAngle(_currentYaw, _targetYaw, turnSpeed * Time.deltaTime);
            ApplyYaw(_currentYaw);

            _animation?.Tick(Time.deltaTime);

            // Keep the quad on the world pixel grid; a sub-pixel offset makes the art shimmer as it moves.
            Vector3 p = transform.position + _displayLocalOffset;
            _display.position = new Vector3(
                Mathf.Round(p.x * pixelsPerUnit) / pixelsPerUnit,
                Mathf.Round(p.y * pixelsPerUnit) / pixelsPerUnit,
                p.z);
        }

        private void ApplyYaw(float yaw)
        {
            if (_yawPivot != null) _yawPivot.localRotation = Quaternion.Euler(0f, yaw + data.modelYawOffset, 0f);
        }

        // ---------------------------------------------------------------- build steps

        private void BuildStage()
        {
            _stageSlot = AcquireStageSlot();
            _stageRoot = new GameObject($"[PixelStage] {name}");
            _stageRoot.transform.position = new Vector3(_stageSlot * StageSpacing, StageY, 0f);

            _yawPivot = new GameObject("YawPivot").transform;
            _yawPivot.SetParent(_stageRoot.transform, false);
        }

        private Animator SpawnModel()
        {
            GameObject model = Instantiate(data.modelPrefab, _yawPivot, false);
            model.transform.localPosition = Vector3.zero;
            model.transform.localRotation = Quaternion.identity;
            model.transform.localScale = Vector3.one * data.modelScale;

            foreach (var attachment in data.attachments)
            {
                if (attachment.prefab == null) continue;
                Transform bone = FindDeep(model.transform, attachment.boneName);
                if (bone == null)
                {
                    Debug.LogWarning($"[{name}] Bone '{attachment.boneName}' not found for {attachment.prefab.name}.", this);
                    continue;
                }
                Instantiate(attachment.prefab, bone, false);
            }

            ConvertMaterials(model);

            Animator animator = model.GetComponentInChildren<Animator>();
            if (animator == null)
            {
                Debug.LogWarning($"[{name}] Model has no Animator - it will render in its bind pose.", this);
                return null;
            }
            animator.runtimeAnimatorController = null; // the playable graph drives it
            animator.applyRootMotion = false;          // the 2D mover owns position
            animator.cullingMode = AnimatorCullingMode.AlwaysAnimate;
            return animator;
        }

        /// <summary>
        /// Swaps every material for the toon shader, keeping the original texture and tint. Pack
        /// materials are often Built-in Standard (pink in URP) and smooth PBR shading looks muddy
        /// at sprite size anyway; flat light bands read as pixel art.
        /// </summary>
        private void ConvertMaterials(GameObject model)
        {
            Shader shader = toonShader != null ? toonShader : Shader.Find("PixelForge/ToonModel");
            var converted = new Dictionary<Material, Material>();

            foreach (Renderer r in model.GetComponentsInChildren<Renderer>(true))
            {
                Material[] mats = r.sharedMaterials;
                for (int i = 0; i < mats.Length; i++)
                {
                    Material src = mats[i];
                    if (src == null) continue;
                    if (!converted.TryGetValue(src, out Material toon))
                    {
                        toon = new Material(shader) { name = src.name + " (Toon)" };
                        toon.SetTexture("_BaseMap", ReadTexture(src));
                        toon.SetColor("_BaseColor", ReadColor(src));
                        converted.Add(src, toon);
                        _ownedMaterials.Add(toon);
                    }
                    mats[i] = toon;
                }
                r.sharedMaterials = mats;
                r.shadowCastingMode = ShadowCastingMode.Off;
                r.receiveShadows = false;
                if (r is SkinnedMeshRenderer smr) smr.updateWhenOffscreen = true;
            }
        }

        private void BuildCamera(out int originRow)
        {
            int size = Mathf.Max(8, data.renderSize & ~1); // even, so the quad centres on a whole pixel
            float pitch = data.cameraPitch * Mathf.Deg2Rad;
            float sinP = Mathf.Sin(pitch), cosP = Mathf.Cos(pitch);

            // Extent of the model measured from its feet, valid for any yaw.
            Bounds b = ModelBounds(_yawPivot);
            Vector3 origin = _yawPivot.position;
            float radius = 0f;
            for (int i = 0; i < 8; i++)
            {
                Vector3 c = Corner(b, i) - origin;
                radius = Mathf.Max(radius, new Vector2(c.x, c.z).magnitude);
            }
            float top = Mathf.Max(0.1f, b.max.y - origin.y);

            // Positions along the camera's screen-up axis, relative to the feet.
            float vTop = (top * cosP + radius * sinP) * AnimationPadding;
            float vBottom = -radius * sinP;

            float ortho;
            if (data.pixelsPerModelUnit > 0f)
            {
                ortho = size / (2f * data.pixelsPerModelUnit);
            }
            else
            {
                float usable = 1f - (float)data.footPixels / size;
                ortho = Mathf.Max((vTop - vBottom) / (2f * usable), radius * AnimationPadding);
            }

            // Pin the feet to an exact pixel row so the quad can be anchored without drift.
            float texel = 2f * ortho / size;
            originRow = data.footPixels + Mathf.CeilToInt(-vBottom / texel);
            float centre = ortho - originRow * texel;

            var camGo = new GameObject("StageCamera");
            camGo.transform.SetParent(_stageRoot.transform, false);
            Quaternion rot = Quaternion.Euler(data.cameraPitch, 0f, 0f);
            camGo.transform.SetPositionAndRotation(
                origin + rot * Vector3.up * centre - rot * Vector3.forward * StageCameraDistance,
                rot);

            _renderTexture = new RenderTexture(size, size, 24, RenderTextureFormat.ARGB32)
            {
                name = $"{name}_PixelRT",
                filterMode = FilterMode.Point,
                wrapMode = TextureWrapMode.Clamp,
                antiAliasing = 1,
                useMipMap = false,
            };
            _renderTexture.Create();

            _stageCamera = camGo.AddComponent<Camera>();
            _stageCamera.orthographic = true;
            _stageCamera.orthographicSize = ortho;
            _stageCamera.aspect = 1f;
            _stageCamera.nearClipPlane = 0.1f;
            _stageCamera.farClipPlane = StageCameraDistance * 2f;
            _stageCamera.clearFlags = CameraClearFlags.SolidColor;
            _stageCamera.backgroundColor = Color.clear;
            _stageCamera.allowHDR = false;
            _stageCamera.allowMSAA = false;
            _stageCamera.useOcclusionCulling = false;
            _stageCamera.depth = -100f;
            _stageCamera.targetTexture = _renderTexture;

            var urp = _stageCamera.GetUniversalAdditionalCameraData();
            urp.renderPostProcessing = false;
            urp.antialiasing = AntialiasingMode.None;
            urp.renderShadows = false;
            urp.requiresColorTexture = false;
            urp.requiresDepthTexture = false;
            int rendererIndex = ForwardRendererIndex();
            if (rendererIndex >= 0) urp.SetRenderer(rendererIndex);
        }

        private void BuildDisplay(int originRow)
        {
            int size = _renderTexture.width;
            float worldSize = (float)size / pixelsPerUnit;

            var go = new GameObject("PixelSprite");
            go.transform.SetParent(transform, false);
            go.transform.localScale = new Vector3(worldSize, worldSize, 1f);
            _displayLocalOffset = new Vector3(-(size / 2) / (float)pixelsPerUnit, -originRow / (float)pixelsPerUnit, 0f);
            go.transform.localPosition = _displayLocalOffset;

            go.AddComponent<MeshFilter>().sharedMesh = QuadMesh();
            var mr = go.AddComponent<MeshRenderer>();
            var mat = new Material(displayShader != null ? displayShader : Shader.Find("PixelForge/PixelSprite"))
            {
                name = $"{name}_PixelSprite",
            };
            mat.SetTexture("_MainTex", _renderTexture);
            mat.SetColor("_OutlineColor", outlineColor);
            _ownedMaterials.Add(mat);
            mr.sharedMaterial = mat;
            mr.shadowCastingMode = ShadowCastingMode.Off;
            mr.receiveShadows = false;

            _display = go.transform;
        }

        private void EnsureSortingGroup()
        {
            var group = GetComponent<UnityEngine.Rendering.SortingGroup>();
            if (group == null) group = gameObject.AddComponent<UnityEngine.Rendering.SortingGroup>();
            group.sortingLayerName = sortingLayerName;
            group.sortingOrder = sortingOrder;
        }

        // ---------------------------------------------------------------- teardown

        private void OnDestroy() => Teardown();

        private void Teardown()
        {
            _animation?.Dispose();
            _animation = null;

            if (_stageCamera != null) _stageCamera.targetTexture = null;
            if (_renderTexture != null)
            {
                _renderTexture.Release();
                Destroy(_renderTexture);
                _renderTexture = null;
            }
            foreach (var m in _ownedMaterials) if (m != null) Destroy(m);
            _ownedMaterials.Clear();

            if (_display != null) Destroy(_display.gameObject);
            if (_stageRoot != null) Destroy(_stageRoot);
            _display = null;
            _stageRoot = null;
            _stageCamera = null;
            _yawPivot = null;

            if (_stageSlot >= 0) s_StageSlots[_stageSlot] = false;
            _stageSlot = -1;
        }

        // ---------------------------------------------------------------- helpers

        private static int AcquireStageSlot()
        {
            for (int i = 0; i < s_StageSlots.Count; i++)
            {
                if (s_StageSlots[i]) continue;
                s_StageSlots[i] = true;
                return i;
            }
            s_StageSlots.Add(true);
            return s_StageSlots.Count - 1;
        }

        /// <summary>
        /// The 2D Renderer can't depth-sort a 3D mesh against itself, so stage cameras need the
        /// Universal (forward) renderer. It must be listed in the active URP asset's renderer list.
        /// </summary>
        private static int ForwardRendererIndex()
        {
            if (s_ForwardRendererIndex != int.MinValue) return s_ForwardRendererIndex;
            s_ForwardRendererIndex = -1;

            if (GraphicsSettings.currentRenderPipeline is UniversalRenderPipelineAsset urp)
            {
                var list = urp.rendererDataList;
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] is UniversalRendererData)
                    {
                        s_ForwardRendererIndex = i;
                        break;
                    }
                }
            }

            if (s_ForwardRendererIndex < 0)
                Debug.LogError("[PixelModelView] No Universal Renderer in the active URP asset's Renderer List. " +
                               "Add Assets/Settings/PixelStageRenderer.asset to it, otherwise 3D characters render through the 2D Renderer.");
            return s_ForwardRendererIndex;
        }

        private static Bounds ModelBounds(Transform root)
        {
            var renderers = root.GetComponentsInChildren<Renderer>();
            if (renderers.Length == 0) return new Bounds(root.position + Vector3.up, Vector3.one * 2f);
            Bounds b = renderers[0].bounds;
            for (int i = 1; i < renderers.Length; i++) b.Encapsulate(renderers[i].bounds);
            return b;
        }

        private static Vector3 Corner(Bounds b, int i) => new Vector3(
            (i & 1) == 0 ? b.min.x : b.max.x,
            (i & 2) == 0 ? b.min.y : b.max.y,
            (i & 4) == 0 ? b.min.z : b.max.z);

        private static Transform FindDeep(Transform root, string childName)
        {
            if (root.name == childName) return root;
            foreach (Transform child in root)
            {
                Transform found = FindDeep(child, childName);
                if (found != null) return found;
            }
            return null;
        }

        private static Texture ReadTexture(Material src)
        {
            if (src.HasProperty("_BaseMap") && src.GetTexture("_BaseMap") != null) return src.GetTexture("_BaseMap");
            if (src.HasProperty("_MainTex")) return src.GetTexture("_MainTex");
            return null;
        }

        private static Color ReadColor(Material src)
        {
            if (src.HasProperty("_BaseColor")) return src.GetColor("_BaseColor");
            if (src.HasProperty("_Color")) return src.GetColor("_Color");
            return Color.white;
        }

        /// <summary>Unit quad with its origin at the bottom-left corner.</summary>
        private static Mesh QuadMesh()
        {
            if (s_QuadMesh != null) return s_QuadMesh;
            s_QuadMesh = new Mesh { name = "PixelQuad" };
            s_QuadMesh.SetVertices(new[] { new Vector3(0, 0), new Vector3(1, 0), new Vector3(0, 1), new Vector3(1, 1) });
            s_QuadMesh.SetUVs(0, new[] { new Vector2(0, 0), new Vector2(1, 0), new Vector2(0, 1), new Vector2(1, 1) });
            s_QuadMesh.SetTriangles(new[] { 0, 2, 1, 2, 3, 1 }, 0);
            s_QuadMesh.RecalculateBounds();
            return s_QuadMesh;
        }
    }
}
