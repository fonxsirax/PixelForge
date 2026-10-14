using UnityEngine;
using UnityEngine.AI;

namespace PixelForge.Characters3D
{
    /// <summary>
    /// Moves a character on the 2D (XY) plane. Knows nothing about visuals or input: a brain
    /// (player input, AI) calls Move()/Stop(), and the view reads Velocity to animate.
    ///
    /// Walls come from the NavMeshPlus surface already baked in the scenes: NavMeshAgent.Move
    /// slides along navmesh edges. Without a navmesh under the character it falls back to moving
    /// the transform freely, so it still works in an unbaked test scene.
    /// </summary>
    [RequireComponent(typeof(Rigidbody2D))]
    public class CharacterMover2D : MonoBehaviour
    {
        [Tooltip("Units/s² - high values feel responsive for a player character.")]
        [SerializeField] private float acceleration = 40f;
        [SerializeField] private bool useNavMesh = true;

        /// <summary>Measured ground velocity this frame (already includes wall sliding/blocking).</summary>
        public Vector2 Velocity { get; private set; }

        private Rigidbody2D _body;
        private NavMeshAgent _agent;
        private Vector2 _desiredVelocity;
        private Vector2 _commandedVelocity;

        private bool AgentReady => _agent != null && _agent.enabled && _agent.isOnNavMesh;

        private void Awake()
        {
            // Position is driven by this script (or the agent); the body only exists for
            // collision/trigger callbacks, so physics must never push it around.
            _body = GetComponent<Rigidbody2D>();
            _body.bodyType = RigidbodyType2D.Kinematic;
            _body.gravityScale = 0f;
            _body.freezeRotation = true;

            if (!useNavMesh) return;
            _agent = GetComponent<NavMeshAgent>();
            if (_agent == null) _agent = gameObject.AddComponent<NavMeshAgent>();
            // NavMeshPlus bakes in the XY plane; without these the agent would treat Y as "up".
            _agent.updateRotation = false;
            _agent.updateUpAxis = false;
            _agent.angularSpeed = 0f;
        }

        /// <summary>Steer this frame. direction is clamped to length 1.</summary>
        public void Move(Vector2 direction, float speed)
        {
            _desiredVelocity = Vector2.ClampMagnitude(direction, 1f) * speed;
        }

        public void Stop()
        {
            _desiredVelocity = Vector2.zero;
            _commandedVelocity = Vector2.zero;
        }

        private void Update()
        {
            float dt = Time.deltaTime;
            if (dt <= 0f) return;

            _commandedVelocity = Vector2.MoveTowards(_commandedVelocity, _desiredVelocity, acceleration * dt);
            Vector3 before = transform.position;

            if (_commandedVelocity.sqrMagnitude > 0f)
            {
                Vector3 delta = _commandedVelocity * dt;
                if (AgentReady) _agent.Move(delta);
                else transform.position += delta;
            }

            Velocity = (Vector2)(transform.position - before) / dt;
        }
    }
}
