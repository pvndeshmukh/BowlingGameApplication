namespace BowlingService;

/// <summary>
/// This class describes the frame score 
/// If in two tries, fails to knock down all pins then score for that frame is the total number of pins knocked down in two tries.
/// This is very important class performs critical calculations when roller knock downs pins
/// Score for the frame is sum of total pins knock down
/// Frame Score = roll1 + roll2
/// </summary>
public class FrameScore
{
    /// <summary>
    /// GetFrameScore will give you sum for the knock downs pins in current frame
    /// </summary>
    public static int GetFrameScore(string rolls, int frameIndex)
    {
        int score;
        if (rolls[frameIndex] == 'X')
        {
            score = (int)Bonus.Ten;
        }
        else
        {
            int.TryParse(rolls[frameIndex].ToString(), out score);
        }

        int scoreSecond;
        if (rolls[frameIndex + 1] == 'X')
        {
            scoreSecond = (int)Bonus.Ten;
        }
        else
        {
            int.TryParse(rolls[frameIndex + 1].ToString(), out scoreSecond);
        }
        var total = score + scoreSecond;

        return total;
    }
}
