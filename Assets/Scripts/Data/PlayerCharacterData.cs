using UnityEngine;

namespace PixelForge.Data
{
    /// <summary>
    /// Data asset for the main character (trainer/farmer). Same base as MonsterData
    /// (CharacterAnimationSet) so it plugs into the exact same generic motor/animator -
    /// only the fields specific to the player role live here.
    /// </summary>
    [CreateAssetMenu(fileName = "NewPlayerCharacterData", menuName = "PixelForge/Player Character Data")]
    public class PlayerCharacterData : CharacterAnimationSet
    {
        [Header("Player")]
        [Tooltip("Placeholder for future inventory system.")]
        public int inventorySlots = 20;
    }
}
