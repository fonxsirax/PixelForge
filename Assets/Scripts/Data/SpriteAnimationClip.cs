using UnityEngine;

namespace PixelForge.Data
{
    /// <summary>
    /// One row of a spritesheet: the frames for a single AnimationState, sliced in the
    /// Unity Sprite Editor and dragged in here in order.
    /// </summary>
    [System.Serializable]
    public class SpriteAnimationClip
    {
        public AnimationState state;

        [Tooltip("Assign the sliced spritesheet (Sprite Mode: Multiple) and use the asset's " +
                 "\"Auto-fill frames from sheets\" context menu to populate 'frames' automatically, " +
                 "in _0.._N order. You can still drag frames by hand instead.")]
        public Texture2D sheet;

        public Sprite[] frames;

        [Min(0.01f)]
        public float frameRate = 8f;

        /// <summary>
        /// Whether this clip repeats. Derived from the state - Attack/Collect/Faint play once,
        /// everything else loops - instead of a serialized checkbox. This avoids the Unity gotcha
        /// where a list element added via the Inspector ignores field initializers and would arrive
        /// as false, making walk/idle play only once.
        /// </summary>
        public bool Loops =>
            state != AnimationState.Attack &&
            state != AnimationState.Collect &&
            state != AnimationState.Faint;
    }
}
