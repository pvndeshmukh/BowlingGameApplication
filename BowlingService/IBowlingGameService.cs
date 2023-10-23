namespace BowlingService;

/// <summary>
/// This abstract blueprint of bowling game system
/// </summary>
public interface IBowlingGameService
{
    int CalculateScore(string rolls);
}