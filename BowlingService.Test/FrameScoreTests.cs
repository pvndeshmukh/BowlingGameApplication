namespace BowlingService.Test;

public class FrameScoreTests
{
    [Fact]
    public void GetFrameScore_ReturnsCorrectScoreForStrikeFollowedByOpenFrame()
    {
        // Arrange
        string rolls = "X5-";
        int frameIndex = 0;

        // Act
        int score = FrameScore.GetFrameScore(rolls, frameIndex);

        // Assert
        Assert.Equal(15, score);
    }   

    [Fact]
    public void GetFrameScore_ReturnsCorrectScoreForOpenFrame()
    {
        // Arrange
        string rolls = "53";
        int frameIndex = 0;

        // Act
        int score = FrameScore.GetFrameScore(rolls, frameIndex);

        // Assert
        Assert.Equal(8, score);
    }
    
    [Fact]
    public void GetFrameScore_ReturnsCorrectScoreForTwoStrikesSeparatedByStrike()
    {
        // Arrange
        string rolls = "X-";
        int frameIndex = 0;

        // Act
        int score = FrameScore.GetFrameScore(rolls, frameIndex);

        // Assert
        Assert.Equal(10, score);
    }

    [Fact]
    public void GetFrameScore_ReturnsCorrectScoreForStrikeFollowedBySpare()
    {
        // Arrange
        string rolls = "X9/";
        int frameIndex = 0;

        // Act
        int score = FrameScore.GetFrameScore(rolls, frameIndex);

        // Assert
        Assert.Equal(19, score);
    }

    [Fact]
    public void GetFrameScore_ReturnsCorrectScoreForStrikeFollowedByNonStrikeFrame1()
    {
        // Arrange
        string rolls = "X4";
        int frameIndex = 0;

        // Act
        int score = FrameScore.GetFrameScore(rolls, frameIndex);

        // Assert
        Assert.Equal(14, score);
    }    

    [Fact]
    public void GetFrameScore_ReturnsCorrectScoreForStrikeFollowedByNonStrikeFrame2()
    {
        // Arrange
        string rolls = "X5";
        int frameIndex = 0;

        // Act
        int score = FrameScore.GetFrameScore(rolls, frameIndex);

        // Assert
        Assert.Equal(15, score);
    }

    [Fact]
    public void GetFrameScore_ReturnsCorrectScoreForStrikeFollowedByNonStrikeFrame3()
    {
        // Arrange
        string rolls = "X9";
        int frameIndex = 0;

        // Act
        int score = FrameScore.GetFrameScore(rolls, frameIndex);

        // Assert
        Assert.Equal(19, score);
    }

    [Fact]
    public void GetFrameScore_ReturnsCorrectScoreForStrikeFollowedByTwoOpenFrames()
    {
        // Arrange
        string rolls = "X--";
        int frameIndex = 0;

        // Act
        int score = FrameScore.GetFrameScore(rolls, frameIndex);

        // Assert
        Assert.Equal(10, score);
    }
}
