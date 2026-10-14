using System;
using UnityEngine;

namespace PixelForge.Characters3D
{
    /// <summary>
    /// Everything that defines one 3D-rendered character: which model, which clips, how fast it
    /// moves and how it is turned into pixels. Same rule as the 2D pipeline: adding a character
    /// means duplicating this asset and swapping the model/clips - no new code.
    ///
    /// Clips are plain AnimationClips played through Playables, so no AnimatorController asset
    /// is needed. Humanoid clips work across every model that shares the avatar (all KayKit
    /// Rig_Medium characters, for instance).
    /// </summary>
    [CreateAssetMenu(menuName = "PixelForge/Character 3D Data", fileName = "NewCharacter3D")]
    public class Character3DData : ScriptableObject
    {
        [Serializable]
        public struct Attachment
        {
            [Tooltip("Name of the bone (Transform) inside the model to parent the prop to, e.g. handslot.r")]
            public string boneName;
            public GameObject prefab;
        }

        [Header("Identity")]
        public string displayName;

        [Header("Model")]
        [Tooltip("Rigged model prefab. Must have an Animator with an Avatar (controller is not needed).")]
        public GameObject modelPrefab;
        [Tooltip("Props parented to bones at spawn (weapons, shields, hats...).")]
        public Attachment[] attachments = Array.Empty<Attachment>();
        [Tooltip("Added to the facing yaw, for models whose 'forward' is not +Z.")]
        public float modelYawOffset;
        public float modelScale = 1f;

        [Header("Movement (world units/s - 1 unit = 1 tile = 32 px)")]
        public float walkSpeed = 2.5f;
        public float runSpeed = 4.5f;

        [Header("Animation clips")]
        public AnimationClip idle;
        public AnimationClip walk;
        public AnimationClip run;
        [Tooltip("Played once on the attack input.")]
        public AnimationClip attack;
        [Tooltip("Played once on the interact/collect input.")]
        public AnimationClip interact;
        public AnimationClip hurt;
        public AnimationClip death;
        [Tooltip("Speed (units/s) at which the walk clip looks natural; playback rate scales from it to limit foot sliding.")]
        public float walkClipSpeed = 2.5f;
        [Tooltip("Speed (units/s) at which the run clip looks natural.")]
        public float runClipSpeed = 4.5f;

        [Header("Pixelization")]
        [Tooltip("Square render target in pixels. With PPU 32, 64 px = a 2x2 tile area on screen.")]
        public int renderSize = 64;
        [Tooltip("Model units per screen pixel is derived from this. 0 = auto-fit the model in renderSize. " +
                 "Set a fixed value to keep the same pixel density across every character.")]
        public float pixelsPerModelUnit = 0f;
        [Tooltip("Rows of empty pixels kept under the feet (room for the outline).")]
        public int footPixels = 3;
        [Tooltip("How much the camera looks down, in degrees. 90 = straight top-down, 0 = pure side view.")]
        [Range(0f, 90f)] public float cameraPitch = 35f;
        [Tooltip("Pose updates per second. 8-12 gives the 'on twos' pixel-art cadence; 0 = smooth.")]
        public float animationFps = 12f;
        [Tooltip("Facing snaps to this many directions (8 = classic pixel art). 0 = free rotation.")]
        public int facingDirections = 8;
    }
}
