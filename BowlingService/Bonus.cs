namespace BowlingService;

/// <summary>
/// This enum describes the bonus number getting added into scores
/// For now it is set to number 10 i.e 10 extra points will get added to your score whenever certain conditions met
/// It's very easy to change and modifiy bonus points since this enum is source of truth for for the bonus getting calculated into system
/// (Strike) X = 10 + (all the rolls from the next/following frame)
/// (Spare) / = 10 + (frist roll from the next/following frame)
/// Frame Score = roll1 + roll2
/// </summary>
public enum Bonus
{
    Ten = 10
}