using UnityEngine;

namespace PixelForge.Data
{
    /// <summary>
    /// One gatherable resource (tree, bush, mining rock, etc.) = one asset. Same idea as
    /// MonsterData: the future ResourceNode behaviour script reads this data instead of
    /// having one script per resource type.
    /// </summary>
    [CreateAssetMenu(fileName = "NewResourceNodeData", menuName = "PixelForge/Resource Node Data")]
    public class ResourceNodeData : ScriptableObject
    {
        [Header("Identity")]
        public string resourceId;
        public string displayName;

        [Header("Visuals")]
        public Sprite fullSprite;
        public Sprite depletedSprite;

        [Header("Yield")]
        public string itemId;
        [Min(1)] public int minYield = 1;
        [Min(1)] public int maxYield = 3;

        [Header("Gathering")]
        [Tooltip("A monster's gatherPower must be >= this to collect from this node.")]
        public int requiredGatherPower = 1;
        [Min(0.1f)] public float gatherTimeSeconds = 1.5f;
        [Min(0f)] public float respawnTimeSeconds = 30f;
    }
}
