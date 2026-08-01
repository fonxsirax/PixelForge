using UnityEngine;
using UnityEngine.InputSystem;
using PixelForge.Core;

namespace PixelForge.Player
{
    /// <summary>
    /// Main character controller (trainer/farmer). Reuses the exact same movement and
    /// animation core as every monster (CharacterMotor2D) - the only thing specific to
    /// the player is how it reads input. Uses Unity's Input System package (already
    /// installed in this project).
    /// </summary>
    public class PlayerController : CharacterMotor2D
    {
        [SerializeField] private PixelForge.Data.PlayerCharacterData data;

        [Header("Input")]
        [SerializeField] private Key attackKey = Key.Space;
        [SerializeField] private Key collectKey = Key.E;

        protected override void Awake()
        {
            base.Awake();
            // ApplyAnimationSet also pushes data.moveSpeed into the NavMeshAgent.
            if (data != null) ApplyAnimationSet(data);
        }

        protected override void Update()
        {
            ReadInput();
            base.Update();
        }

        private void ReadInput()
        {
            var keyboard = Keyboard.current;
            if (keyboard == null) return;

            Vector2 input = Vector2.zero;
            if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed) input.y += 1f;
            if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed) input.y -= 1f;
            if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed) input.x += 1f;
            if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed) input.x -= 1f;

            SetMoveInput(input);

            if (keyboard[attackKey].wasPressedThisFrame) TriggerAttack();
            if (keyboard[collectKey].wasPressedThisFrame) TriggerCollect();
        }
    }
}
