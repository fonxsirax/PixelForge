using UnityEngine;

namespace PixelForge.Data
{
    public enum MonsterElement
    {
        Normal,
        Fire,
        Water,
        Grass,
        Electric,
        Rock,
        Ice,
        Bug
    }

    /// <summary>
    /// One monster species = one asset. Duplicate this asset, swap the spritesheet frames
    /// and the stats, and you have a new monster - MonsterController (the code) never changes.
    /// Right-click in the Project window: Create > PixelForge > Monster Data.
    /// </summary>
    [CreateAssetMenu(fileName = "NewMonsterData", menuName = "PixelForge/Monster Data")]
    public class MonsterData : CharacterAnimationSet
    {
        [Header("Species")]
        public string speciesId;
        [TextArea] public string description;
        public MonsterElement element = MonsterElement.Normal;

        [Header("Base Stats")]
        public int maxHealth = 20;
        public int attackPower = 5;
        public int defense = 5;

        [Header("Roles")]
        public bool canBattle = true;
        public bool canCollectResources = false;

        [Tooltip("Higher gather power unlocks tougher resource nodes (see ResourceNodeData.requiredGatherPower).")]
        public int gatherPower = 1;
    }
}
