namespace BowlingService.Test;

public class BowlingGameServiceTests
{
    [Theory]
    [InlineData("X9/5/72XXX9-8/9/X", 187)] // Problem statement input
    [InlineData("X454/32", 46)] // Normal mix game    
    [InlineData("9-9-9-9-9-9-9-9-9-9-", 90)] // All misses    
    [InlineData("X7/9-X-88/-6XXX81", 167)] // Mixed strikes, spares, and open frames
    [InlineData("--------------------", 0)] // All gutter
    [InlineData("X5/------------------", 30)] // Strike, spare, and all misses    
    [InlineData("XXXXXXXXXXXX", 300)] // Perfect game    
    public void CalculateScore_ShouldReturnCorrectTotalScore(string rolls, int expectedScore)
    {
        // Arrange
        BowlingGameService game = new();

        // Act
        int actualScore = game.CalculateScore(rolls);

        // Assert
        Assert.Equal(expectedScore, actualScore);
    }

    [Fact]
    public void CalculateScore_ReturnsCorrectScoreForAllStrikesWithMiss()
    {
        // Arrange
        string rolls = "X-X-X-X-X-X-X-X-X-XX-";

        // Act
        BowlingGameService game = new BowlingGameService();
        int score = game.CalculateScore(rolls);

        // Assert
        Assert.Equal(120, score);
    }

    [Fact]
    public void CalculateScore_ReturnsCorrectScoreForAllSpares()
    {
        // Arrange
        string rolls = "5/5/5/5/5/5/5/5/5/5/5";

        // Act
        BowlingGameService game = new BowlingGameService();
        int score = game.CalculateScore(rolls);

        // Assert
        Assert.Equal(150, score);
    }

    [Fact]
    public void CalculateScore_ReturnsCorrectScoreForAllOpenFrames()
    {
        // Arrange
        string rolls = "123456789123456789";

        // Act
        BowlingGameService game = new BowlingGameService();
        int score = game.CalculateScore(rolls);

        // Assert
        Assert.Equal(90, score);
    }

    [Fact]
    public void CalculateScore_ReturnsCorrectScoreForAllGutter()
    {
        // Arrange
        string rolls = "--------------------";

        // Act
        BowlingGameService game = new BowlingGameService();
        int score = game.CalculateScore(rolls);

        // Assert
        Assert.Equal(0, score);
    }

    [Fact]
    public void CalculateScore_ReturnsCorrectScoreForMixedStrikesAndSpares()
    {
        // Arrange
        string rolls = "X9/5/X5/9/XX9/XX-";

        // Act
        BowlingGameService game = new BowlingGameService();
        int score = game.CalculateScore(rolls);

        // Assert
        Assert.Equal(203, score);
    }

    [Fact]
    public void CalculateScore_ReturnsCorrectScoreForMixedStrikesAndOpenFrames()
    {
        // Arrange
        string rolls = "X9-5-X5-9-XX9-";

        // Act
        BowlingGameService game = new BowlingGameService();
        int score = game.CalculateScore(rolls);

        // Assert
        Assert.Equal(119, score);
    }

    [Fact]
    public void CalculateScore_ReturnsCorrectScoreForMixedSparesAndStrikes()
    {
        // Arrange
        string rolls = "5/X5/X5/X5/X5/X5/X5/X5/X5/X5/X";

        // Act
        BowlingGameService game = new BowlingGameService();
        int score = game.CalculateScore(rolls);

        // Assert
        Assert.Equal(200, score);
    }

    [Fact]
    public void CalculateScore_ReturnsCorrectScoreForMixedStrikesSparesAndOpenFrames()
    {
        // Arrange
        string rolls = "X9/5/XX9-5-9/X5/-";

        // Act
        BowlingGameService game = new BowlingGameService();
        int score = game.CalculateScore(rolls);

        // Assert
        Assert.Equal(167, score);
    }

    [Fact]
    public void CalculateScore_ReturnsCorrectScoreForAllOpenFramesWithBonus()
    {
        // Arrange
        string rolls = "123456789123456789XX/";

        // Act
        BowlingGameService game = new BowlingGameService();
        int score = game.CalculateScore(rolls);

        // Assert
        Assert.Equal(110, score);
    }

    [Fact]
    public void CalculateScore_ReturnsCorrectScoreForMixedStrikesSparesAndNonStrikes()
    {
        // Arrange
        string rolls = "X9/5/XX9-12345678-";

        // Act
        BowlingGameService game = new BowlingGameService();
        int score = game.CalculateScore(rolls);

        // Assert
        Assert.Equal(148, score);
    }

    [Fact]
    public void CalculateScore_ReturnsCorrectScoreForMixedStrikesOpenFramesAndSpares()
    {
        // Arrange
        string rolls = "X9-5-X9/5/9-X5/XX-";

        // Act
        BowlingGameService game = new BowlingGameService();
        int score = game.CalculateScore(rolls);

        // Assert
        Assert.Equal(156, score);
    }

    [Fact]
    public void CalculateScore_ReturnsCorrectScoreForMixedStrikesSparesAndOpenFramesWithBonus()
    {
        // Arrange
        string rolls = "X9/5/X9-5-9/X5/XX-";

        // Act
        BowlingGameService game = new BowlingGameService();
        int score = game.CalculateScore(rolls);

        // Assert
        Assert.Equal(168, score);
    }
}