namespace PixelForge.Data
{
    /// <summary>
    /// Every pose a 2D character can ever need. This is the contract every spritesheet
    /// must satisfy: same states, same order, regardless of which monster/character it is.
    /// The generic controller only ever asks for one of these - never for "monster-specific" logic.
    /// Left/Right are intentionally NOT separate states: "Side" is drawn once (facing right)
    /// and CharacterMotor2D mirrors it via SpriteRenderer.flipX when facing left.
    /// </summary>
    public enum AnimationState
    {
        IdleDown,
        IdleUp,
        IdleSide,
        WalkDown,
        WalkUp,
        WalkSide,
        Attack,
        Collect,
        Hurt,
        Faint
    }
}
