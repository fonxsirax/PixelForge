using UnityEngine;
using PixelForge.Core;
using PixelForge.Data;
using PixelForge.Player;

namespace PixelForge.Monsters
{
    /// <summary>
    /// Drives ANY monster species. The species-specific look, stats and roles come entirely
    /// from the injected MonsterData asset - this script never changes between species.
    /// To add a new monster: create a MonsterData asset, slice its spritesheet into the
    /// AnimationState slots, drop the asset in the "data" slot below. No new code needed.
    /// </summary>
    public class MonsterController : CharacterMotor2D
    {
        // How far the target must drift before we ask for a new path. Repathing every frame is
        // the usual reason a crowd of agents tanks the frame rate.
        private const float RepathDistance = 0.35f;

        [SerializeField] private MonsterData data;

        [Header("Follow AI")]
        [Tooltip("Who to chase. Leave empty to auto-find the player in the scene at start.")]
        [SerializeField] private Transform followTarget;
        [Tooltip("Stops once it gets this close to the target (world units), so it trails instead of overlapping it.")]
        [SerializeField] private float stopDistance = 1.5f;

        private Vector3 _lastRequestedDestination;
        private bool _hasRequestedDestination;

        public MonsterData Data => data;
        public int CurrentHealth { get; private set; }

        protected override void Awake()
        {
            base.Awake();
            agent.stoppingDistance = stopDistance;

            if (data != null) Initialize(data);

            // Convenience for testing: if no target was wired in the Inspector, grab the player.
            if (followTarget == null)
            {
                var player = FindFirstObjectByType<PlayerController>();
                if (player != null) followTarget = player.transform;
            }
        }

        protected override void Update()
        {
            UpdateFollowAI();
            base.Update();
        }

        private void UpdateFollowAI()
        {
            if (followTarget == null)
            {
                StopMovement();
                _hasRequestedDestination = false;
                return;
            }

            Vector3 target = followTarget.position;

            bool targetMoved = !_hasRequestedDestination ||
                (target - _lastRequestedDestination).sqrMagnitude >= RepathDistance * RepathDistance;

            // An attack/collect animation clears the path (the character holds position). Without
            // this check the monster would stay frozen afterwards until the target happened to move.
            bool lostPath = AgentReady && !agent.hasPath && !agent.pathPending &&
                (target - transform.position).sqrMagnitude > stopDistance * stopDistance;

            if (!targetMoved && !lostPath) return;

            _lastRequestedDestination = target;
            _hasRequestedDestination = true;
            // stoppingDistance keeps it trailing the target instead of piling onto it.
            SetDestination(target);
        }

        /// <summary>(Re)spawns this controller as a given species at runtime (e.g. object pooling).</summary>
        public void Initialize(MonsterData monsterData)
        {
            data = monsterData;
            CurrentHealth = data.maxHealth;
            _hasRequestedDestination = false;
            ResetMotorState();
            ApplyAnimationSet(data); // also pushes moveSpeed into the agent
        }

        /// <summary>Hook for a future AI/behaviour script - steer it directly, bypassing pathfinding.</summary>
        public void Move(Vector2 direction) => SetMoveInput(direction);

        /// <summary>Hook for a future AI/behaviour script - send it to a point via pathfinding.</summary>
        public void MoveTo(Vector3 worldPoint) => SetDestination(worldPoint);
    }
}
