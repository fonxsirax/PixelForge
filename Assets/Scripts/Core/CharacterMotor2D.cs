using UnityEngine;
using UnityEngine.AI;
using PixelForge.Data;
// See the same comment in SpriteAnimator.cs: UnityEngine.AnimationState (legacy Animation
// component) collides with our enum name, so we alias it explicitly.
using AnimationState = PixelForge.Data.AnimationState;

namespace PixelForge.Core
{
    /// <summary>
    /// Generic top-down 2D motor shared by EVERY character in the game - monsters, the
    /// player, future NPCs. It never knows which species/character it's driving; that
    /// comes entirely from the CharacterAnimationSet asset injected via ApplyAnimationSet().
    /// Subclasses only decide WHEN to move/attack/collect (input, AI, ...) - this class
    /// decides HOW that looks (animation) and moves (navigation).
    ///
    /// Movement is free-form and runs through a NavMeshAgent on the NavMeshPlus 2D surface,
    /// so walls and obstacles come from the baked navmesh instead of a collider probe.
    /// Two steering modes, both feeding the same agent:
    ///   - Steer:       a direction vector every frame (player input). Uses NavMeshAgent.Move,
    ///                  which slides along navmesh edges instead of pathfinding.
    ///   - Destination: a world point (AI). The agent pathfinds there on its own.
    /// </summary>
    [RequireComponent(typeof(SpriteAnimator))]
    [RequireComponent(typeof(BoxCollider2D))]
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(NavMeshAgent))]
    public abstract class CharacterMotor2D : MonoBehaviour
    {
        protected enum BehaviorState { Idle, Walk, Attack, Collect, Hurt, Faint }

        /// <summary>How the agent is being told where to go this frame.</summary>
        protected enum MoveMode { Steer, Destination }

        [Header("Movement (moveSpeed overwritten by the injected data asset)")]
        [Tooltip("Movement speed in world units per second. 1 unit = 1 tile = 32 px.")]
        [SerializeField] protected float moveSpeed = 2.5f;
        [Tooltip("How fast the agent reaches its speed. High values feel responsive for a player character.")]
        [SerializeField] protected float acceleration = 24f;
        [Tooltip("Below this speed the character is treated as standing still and plays the idle pose.")]
        [SerializeField] protected float idleSpeedThreshold = 0.05f;

        protected SpriteAnimator animator;
        protected Rigidbody2D body;
        protected BoxCollider2D box;
        protected NavMeshAgent agent;

        protected BehaviorState currentBehavior = BehaviorState.Idle;
        protected Vector2 facingDirection = Vector2.down;

        private MoveMode _mode = MoveMode.Steer;
        private Vector2 _steerInput;
        // Remembers which way we were last heading horizontally, so the sprite doesn't snap back
        // to its default facing while walking straight up or down.
        private float _lastHorizontalSign = 1f;

        /// <summary>True only when the agent is actually sitting on a baked navmesh.</summary>
        protected bool AgentReady => agent != null && agent.enabled && agent.isOnNavMesh;

        protected virtual void Awake()
        {
            animator = GetComponent<SpriteAnimator>();
            body = GetComponent<Rigidbody2D>();
            box = GetComponent<BoxCollider2D>();

            // RequireComponent covers prefabs edited in the editor, but a prefab authored before
            // this requirement existed can still reach runtime without one.
            agent = GetComponent<NavMeshAgent>();
            if (agent == null) agent = gameObject.AddComponent<NavMeshAgent>();

            // NavMeshPlus bakes the surface in the XY plane. Without these two the agent would
            // rotate the sprite and try to stand up along +Y as if this were a 3D scene.
            agent.updateRotation = false;
            agent.updateUpAxis = false;
            agent.angularSpeed = 0f;
            agent.acceleration = acceleration;
            agent.speed = moveSpeed;

            // The Rigidbody2D no longer drives movement - the agent writes the transform. It stays
            // for collision/trigger callbacks, so it must not be pushed around by physics.
            body.bodyType = RigidbodyType2D.Kinematic;
            body.gravityScale = 0f;
            body.freezeRotation = true;
            body.interpolation = RigidbodyInterpolation2D.Interpolate;
        }

        /// <summary>Injects the asset that defines how this character looks, moves and collides.</summary>
        protected void ApplyAnimationSet(CharacterAnimationSet data)
        {
            animator.Setup(data);
            box.size = data.colliderSize;
            box.offset = data.colliderOffset;
            SetMoveSpeed(data.moveSpeed);
            animator.Play(ToAnimationState(BehaviorState.Idle, facingDirection));
        }

        protected void SetMoveSpeed(float speed)
        {
            moveSpeed = speed;
            if (agent != null) agent.speed = speed;
        }

        /// <summary>
        /// Puts the motor back to a clean standing state. Call this when recycling an instance
        /// (object pooling), otherwise it wakes up carrying the previous occupant's behaviour -
        /// a corpse mid-Faint or a character frozen in a locked attack animation.
        /// </summary>
        protected void ResetMotorState()
        {
            StopMovement();
            animator.OnNonLoopingAnimationFinished = null;
            currentBehavior = BehaviorState.Idle;
            facingDirection = Vector2.down;
            _mode = MoveMode.Steer;
            _lastHorizontalSign = 1f;
        }

        protected virtual void Update()
        {
            UpdateMovement();
            UpdateAnimation();
        }

        private void UpdateMovement()
        {
            // Attack/collect hold position until the animation finishes.
            if (IsInLockedAnimation())
            {
                StopMovement();
                return;
            }

            if (_mode != MoveMode.Steer) return;

            // Direct control: a leftover path would fight the steering vector every frame.
            if (AgentReady && agent.hasPath) agent.ResetPath();

            if (_steerInput.sqrMagnitude < 0.0001f) return;

            Vector3 delta = (Vector3)(_steerInput * moveSpeed * Time.deltaTime);
            if (AgentReady) agent.Move(delta);
            else transform.position += delta; // no navmesh baked in this scene yet - move anyway
        }

        private void UpdateAnimation()
        {
            Vector2 velocity = CurrentVelocity();
            bool moving = velocity.sqrMagnitude > idleSpeedThreshold * idleSpeedThreshold;

            if (moving)
            {
                facingDirection = velocity.normalized;
                if (Mathf.Abs(facingDirection.x) > 0.01f)
                    _lastHorizontalSign = Mathf.Sign(facingDirection.x);
            }

            // The art is drawn facing right and mirrored for the left. Driving this from the last
            // horizontal heading (rather than the current one) keeps the sprite stable while the
            // character walks straight up or down.
            animator.SetFacingLeft(_lastHorizontalSign < 0f);

            if (IsInLockedAnimation()) return;

            currentBehavior = moving ? BehaviorState.Walk : BehaviorState.Idle;
            PlayDirectional(currentBehavior, facingDirection);
        }

        /// <summary>Actual movement this frame, whichever steering mode produced it.</summary>
        protected Vector2 CurrentVelocity()
        {
            if (_mode == MoveMode.Steer) return _steerInput * moveSpeed;
            return AgentReady ? (Vector2)agent.velocity : Vector2.zero;
        }

        /// <summary>Feed a movement axis every frame (player input, or any direct steering).</summary>
        protected void SetMoveInput(Vector2 input)
        {
            _mode = MoveMode.Steer;
            _steerInput = input.sqrMagnitude > 1f ? input.normalized : input;
        }

        /// <summary>Hand navigation over to the agent: it pathfinds to this world point on its own.</summary>
        protected void SetDestination(Vector3 worldPoint)
        {
            _mode = MoveMode.Destination;
            _steerInput = Vector2.zero;
            if (AgentReady) agent.SetDestination(worldPoint);
        }

        /// <summary>Stops the character wherever it is, in either steering mode.</summary>
        protected void StopMovement()
        {
            _steerInput = Vector2.zero;
            if (!AgentReady) return;
            if (agent.hasPath) agent.ResetPath();
            agent.velocity = Vector3.zero;
        }

        public void TriggerAttack()
        {
            if (IsInLockedAnimation()) return;
            StartLockedAnimation(BehaviorState.Attack);
        }

        public void TriggerCollect()
        {
            if (IsInLockedAnimation()) return;
            StartLockedAnimation(BehaviorState.Collect);
        }

        private bool IsInLockedAnimation()
        {
            return currentBehavior == BehaviorState.Attack
                || currentBehavior == BehaviorState.Collect
                || currentBehavior == BehaviorState.Faint;
        }

        private void StartLockedAnimation(BehaviorState state)
        {
            currentBehavior = state;
            StopMovement();
            animator.OnNonLoopingAnimationFinished = OnLockedAnimationFinished;

            // If there's no clip for this action yet (art not ready), don't lock the character into a
            // state whose "finished" callback will never fire - just fall back to Idle so it keeps
            // running "bugado" instead of freezing forever.
            bool started = animator.Play(ToAnimationState(state, facingDirection), restartIfSame: true);
            if (!started)
            {
                animator.OnNonLoopingAnimationFinished = null;
                currentBehavior = BehaviorState.Idle;
            }
        }

        private void OnLockedAnimationFinished()
        {
            animator.OnNonLoopingAnimationFinished = null;
            currentBehavior = BehaviorState.Idle;
        }

        /// <summary>
        /// Plays the pose for this heading, falling back to the Side pose when the up/down art
        /// doesn't exist. Without the fallback a character with side-only art keeps whatever clip
        /// was playing before while it walks north, which reads as "stuck facing the wrong way".
        /// </summary>
        private void PlayDirectional(BehaviorState behavior, Vector2 facing)
        {
            AnimationState wanted = ToAnimationState(behavior, facing);
            if (animator.Play(wanted)) return;

            AnimationState side = behavior == BehaviorState.Walk
                ? AnimationState.WalkSide
                : AnimationState.IdleSide;
            if (wanted != side) animator.Play(side);
        }

        private static AnimationState ToAnimationState(BehaviorState behavior, Vector2 facing)
        {
            switch (behavior)
            {
                case BehaviorState.Attack: return AnimationState.Attack;
                case BehaviorState.Collect: return AnimationState.Collect;
                case BehaviorState.Hurt: return AnimationState.Hurt;
                case BehaviorState.Faint: return AnimationState.Faint;
                case BehaviorState.Walk:
                    if (Mathf.Abs(facing.x) >= Mathf.Abs(facing.y)) return AnimationState.WalkSide;
                    return facing.y > 0f ? AnimationState.WalkUp : AnimationState.WalkDown;
                default:
                    if (Mathf.Abs(facing.x) >= Mathf.Abs(facing.y)) return AnimationState.IdleSide;
                    return facing.y > 0f ? AnimationState.IdleUp : AnimationState.IdleDown;
            }
        }
    }
}
