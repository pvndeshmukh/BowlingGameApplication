namespace BowlingService;

/// <summary>
/// This class describes the spare bonus calculations 
/// If in two tries in the frame all pins gets knocks down, then this is called a SPARE
/// This is very important class performs critical calculations when roller hits spare in second hit of frame
/// Score for the frame is ten plus the frist roll from the following/next frame
/// (Spare) / = 10 + (frist roll from the next/following frame)
/// </summary>
public class SpareBonus
{
    /// <summary>
    /// GetSpareBonus will give you total score for the current frame which is depends frist roll of the following/next frame     
    /// </summary>
    public static int GetSpareBonus(string rolls, int nextRollIndex)
    {
        if (rolls[nextRollIndex] == 'X')
        {
            return (int)Bonus.Ten + (int)Bonus.Ten;
        }

        int.TryParse(rolls[nextRollIndex].ToString(), out var score);

        var total = (int)Bonus.Ten + score;

        return total;
    }
}
