namespace BowlingService;

/// <summary>
/// This class describes the strike bonus calculations 
/// If on first try in the frame all pins gets knocks down, this is called a STRIKE
/// This is very important class performs critical calculations when roller hits strike
/// Score for the frame is ten plus the simple total of the pins knocked down in his next two rolls
/// (Strike) X = 10 + (all the rolls from the next/following frame)
/// </summary>
public class StrikeBonus
{
    /// <summary>
    /// GetStrikeBonus will give you total score for the current frame which is depends on following/next frame     
    /// </summary>
    public static int GetStrikeBonus(string rolls, int nextFrameIndex)
    {
        if (rolls[nextFrameIndex] == 'X' && rolls[nextFrameIndex + 1] == 'X')
        {
            return (int)Bonus.Ten + (int)Bonus.Ten + (int)Bonus.Ten;
        }
        else if (rolls[nextFrameIndex] == 'X' && rolls[nextFrameIndex + 1] != 'X')
        {
            int.TryParse(rolls[nextFrameIndex + 1].ToString(), out var score);

            return (int)Bonus.Ten + (int)Bonus.Ten + score;
        }
        else if (rolls[nextFrameIndex + 1] == '/')
        {
            return (int)Bonus.Ten + (int)Bonus.Ten;
        }
        var total = (int)Bonus.Ten + FrameScore.GetFrameScore(rolls, nextFrameIndex);

        return total;
    }
}
