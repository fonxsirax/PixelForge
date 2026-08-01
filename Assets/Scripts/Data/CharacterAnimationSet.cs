using System.Collections.Generic;
using UnityEngine;

namespace PixelForge.Data
{
    /// <summary>
    /// Base data asset shared by EVERY animated 2D character in the game - monsters, the
    /// player, NPCs, all of it. This is the "enxerto de PNGs" in practice: one generic
    /// controller (CharacterMotor2D) reads one of these assets and never needs to know
    /// which character it's actually driving. To add a new character, create a new asset
    /// of the concrete subtype (MonsterData, PlayerCharacterData, ...), slice its spritesheet,
    /// fill in the AnimationState slots below. No new code required.
    /// </summary>
    public abstract class CharacterAnimationSet : ScriptableObject
    {
        [Header("Identity")]
        public string displayName;
        public Sprite icon;

        [Header("Movement")]
        public float moveSpeed = 2.5f;

        [Header("Animations (one entry per AnimationState you support)")]
        public List<SpriteAnimationClip> animations = new List<SpriteAnimationClip>();

        [Header("Collision (BoxCollider2D auto-configured from this)")]
        public Vector2 colliderSize = new Vector2(0.8f, 0.8f);
        public Vector2 colliderOffset = Vector2.zero;

        private Dictionary<AnimationState, SpriteAnimationClip> _lookup;

        /// <summary>Returns null if that state has no clip assigned yet (e.g. art not ready).</summary>
        public SpriteAnimationClip GetClip(AnimationState state)
        {
            if (_lookup == null) BuildLookup();
            _lookup.TryGetValue(state, out var clip);
            return clip;
        }

        private void BuildLookup()
        {
            _lookup = new Dictionary<AnimationState, SpriteAnimationClip>();
            foreach (var clip in animations)
            {
                if (clip == null || clip.frames == null || clip.frames.Length == 0) continue;
                _lookup[clip.state] = clip;
            }
        }

        private void OnValidate()
        {
            _lookup = null; // force rebuild next GetClip() call after editing in the Inspector
        }

#if UNITY_EDITOR
        /// <summary>
        /// Editor helper: for every clip that has a 'sheet' assigned, loads all of its sliced
        /// sub-sprites and fills 'frames' in _0.._N order. Bakes the result into the asset so it
        /// works in builds (no AssetDatabase at runtime). Right-click the asset ▸ this menu item.
        /// </summary>
        [ContextMenu("Auto-fill frames from sheets")]
        private void AutoFillFramesFromSheets()
        {
            int filled = 0;
            foreach (var clip in animations)
            {
                if (clip == null || clip.sheet == null) continue;
                clip.frames = LoadSheetSprites(clip.sheet);
                filled++;
            }
            _lookup = null;
            UnityEditor.EditorUtility.SetDirty(this);
            Debug.Log($"[{name}] Auto-filled frames for {filled} clip(s) from their sheets.", this);
        }

        private static Sprite[] LoadSheetSprites(Texture2D sheet)
        {
            string path = UnityEditor.AssetDatabase.GetAssetPath(sheet);
            var sprites = new List<Sprite>();
            foreach (var obj in UnityEditor.AssetDatabase.LoadAllAssetsAtPath(path))
            {
                if (obj is Sprite s) sprites.Add(s);
            }
            // Sub-sprite names end in "_<index>"; sort numerically so frame order is _0.._N.
            sprites.Sort((a, b) => TrailingIndex(a.name).CompareTo(TrailingIndex(b.name)));
            return sprites.ToArray();
        }

        private static int TrailingIndex(string spriteName)
        {
            int underscore = spriteName.LastIndexOf('_');
            if (underscore >= 0 && int.TryParse(spriteName.Substring(underscore + 1), out int index))
                return index;
            return 0;
        }
#endif
    }
}
