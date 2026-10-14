using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

namespace PixelForge.Characters3D
{
    /// <summary>
    /// The player's "brain" for the 3D character pipeline: reads input and tells the mover where
    /// to go and the view what to play. All look/feel numbers live in the Character3DData asset.
    /// </summary>
    [RequireComponent(typeof(CharacterMover2D))]
    [RequireComponent(typeof(PixelModelView))]
    public class Player3DController : MonoBehaviour
    {
        [Header("Input")]
        [SerializeField] private Key runKey = Key.LeftShift;
        [SerializeField] private Key attackKey = Key.Space;
        [SerializeField] private Key interactKey = Key.E;

        [Header("Camera")]
        [Tooltip("On start, point the scene's CinemachineCamera at this character if it isn't following anything active.")]
        [SerializeField] private bool claimCinemachineCamera = true;

        private CharacterMover2D _mover;
        private PixelModelView _view;
        private bool _inAction;

        private void Awake()
        {
            _mover = GetComponent<CharacterMover2D>();
            _view = GetComponent<PixelModelView>();
        }

        private void Start()
        {
            if (claimCinemachineCamera) ClaimCamera();
        }

        private void Update()
        {
            var keyboard = Keyboard.current;
            var data = _view.Data;
            if (keyboard == null || data == null) return;

            if (_inAction)
            {
                _mover.Stop();
                return;
            }

            Vector2 input = Vector2.zero;
            if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed) input.y += 1f;
            if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed) input.y -= 1f;
            if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed) input.x += 1f;
            if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed) input.x -= 1f;

            bool running = keyboard[runKey].isPressed;
            _mover.Move(input.normalized, running ? data.runSpeed : data.walkSpeed);
            // Face the input even when a wall blocks the movement.
            _view.SetFacing(input);

            if (keyboard[attackKey].wasPressedThisFrame) StartAction(data.attack);
            else if (keyboard[interactKey].wasPressedThisFrame) StartAction(data.interact);
        }

        private void LateUpdate()
        {
            _view.SetMotion(_mover.Velocity);
        }

        private void StartAction(AnimationClip clip)
        {
            // A missing clip simply does nothing instead of freezing the player in a locked state.
            if (!_view.PlayAction(clip, () => _inAction = false)) return;
            _inAction = true;
            _mover.Stop();
        }

        private void ClaimCamera()
        {
            var cam = FindAnyObjectByType<CinemachineCamera>();
            if (cam == null) return;
            if (cam.Follow == null || !cam.Follow.gameObject.activeInHierarchy) cam.Follow = transform;
        }
    }
}
