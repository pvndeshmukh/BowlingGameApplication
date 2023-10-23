namespace BowlingService;

/// <summary>
/// This class describes concrete implementation of IBowlingGameService
/// </summary>
public class BowlingGameService : IBowlingGameService
{
    public int CalculateScore(string rolls)
    {
        int totalScore = 0;
        int frameIndex = 0;

        for (int frame = (int)Frames.Start; frame <= (int)Frames.End; frame++)
        {
            if (rolls.Length <= frameIndex) break;

            if (rolls[frameIndex] == 'X') // Strike
            {
                totalScore += StrikeBonus.GetStrikeBonus(rolls, frameIndex + 1);
                frameIndex += 1;
            }
            else if (rolls[frameIndex + 1] == '/' || rolls[frameIndex + 1] == 'X') // Spare
            {
                totalScore += SpareBonus.GetSpareBonus(rolls, frameIndex + 2);
                frameIndex += 2;
            }
            else if (rolls[frameIndex] != 'X' && rolls[frameIndex] != '/') // Open frame
            {
                totalScore += FrameScore.GetFrameScore(rolls, frameIndex);
                frameIndex += 2;
            }
        }

        return totalScore;
    }
}
