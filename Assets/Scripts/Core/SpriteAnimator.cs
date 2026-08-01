using UnityEngine;
using PixelForge.Data;
// UnityEngine already defines a legacy "AnimationState" (old Animation component),
// which collides with our enum of the same name. This alias forces every unqualified
// "AnimationState" below to resolve to ours instead of throwing a CS0104 ambiguity error.
using AnimationState = PixelForge.Data.AnimationState;

namespace PixelForge.Core
{
    /// <summary>
    /// Plays the frames of a SpriteAnimationClip on a SpriteRenderer. Knows nothing about
    /// monsters, players or gameplay - it only ever sees a CharacterAnimationSet asset and
    /// an AnimationState to play. This is what makes it reusable for every character.
    /// </summary>
    [RequireComponent(typeof(SpriteRenderer))]
    public class SpriteAnimator : MonoBehaviour
    {
        // Fallback frame rate used when a clip's frameRate is left at 0. Unity creates newly-added
        // list elements without running the field initializer (frameRate = 8f), so a fresh clip can
        // arrive here at 0, which would otherwise freeze the animation at ~1 frame per 100s.
        private const float DefaultFrameRate = 8f;

        private SpriteRenderer _renderer;
        private CharacterAnimationSet _data;
        private SpriteAnimationClip _currentClip;
        private AnimationState _currentState;
        private int _frameIndex;
        private float _timer;
        private bool _finished;

        /// <summary>Fired when a non-looping clip (Attack/Collect/Faint) reaches its last frame.</summary>
        public System.Action OnNonLoopingAnimationFinished;

        public AnimationState CurrentState => _currentState;

        private void Awake()
        {
            EnsureRenderer();
        }

        // The renderer is resolved lazily as well as in Awake: PlayerController.Awake() can call
        // Play() before this component's own Awake() has run (Awake order between components on the
        // same GameObject is undefined), which would otherwise NullReference on _renderer.
        private void EnsureRenderer()
        {
            if (_renderer == null) _renderer = GetComponent<SpriteRenderer>();
        }

        public void Setup(CharacterAnimationSet data)
        {
            _data = data;
        }

        /// <summary>Mirrors the "Side" pose horizontally. Assumes source art faces right by default.</summary>
        public void SetFacingLeft(bool faceLeft)
        {
            EnsureRenderer();
            _renderer.flipX = faceLeft;
        }

        /// <summary>
        /// Switches to a new pose. Returns true if a clip is now playing for that state, false if
        /// there is no art for it (so callers can avoid getting stuck waiting on an animation that
        /// will never play). No-op returning true if already playing that state (unless restartIfSame).
        /// </summary>
        public bool Play(AnimationState state, bool restartIfSame = false)
        {
            if (_data == null) return false;
            if (!restartIfSame && state == _currentState && _currentClip != null) return true;

            var clip = _data.GetClip(state);
            if (clip == null) return false; // no art assigned yet for this state - keep showing last frame

            _currentState = state;
            _currentClip = clip;
            _frameIndex = 0;
            _timer = 0f;
            _finished = false;
            EnsureRenderer();
            _renderer.sprite = clip.frames[0];
            return true;
        }

        private void Update()
        {
            if (_currentClip == null || _finished) return;

            _timer += Time.deltaTime;
            float fps = _currentClip.frameRate > 0f ? _currentClip.frameRate : DefaultFrameRate;
            float frameDuration = 1f / fps;

            if (_timer < frameDuration) return;

            _timer -= frameDuration;
            _frameIndex++;

            if (_frameIndex >= _currentClip.frames.Length)
            {
                if (_currentClip.Loops)
                {
                    _frameIndex = 0;
                }
                else
                {
                    _frameIndex = _currentClip.frames.Length - 1;
                    _finished = true;
                    OnNonLoopingAnimationFinished?.Invoke();
                }
            }

            _renderer.sprite = _currentClip.frames[_frameIndex];
        }
    }
}
