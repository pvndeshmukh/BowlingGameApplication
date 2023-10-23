namespace BowlingService.Test;

public class StrikeBonusTests
{
    [Fact]
    public void GetStrikeBonus_ReturnsCorrectBonusForStrikeFollowedByStrike()
    {
        // Arrange
        string rolls = "XXXXXXXXXXXX";
        int nextFrameIndex = 0;

        // Act
        int bonus = StrikeBonus.GetStrikeBonus(rolls, nextFrameIndex);

        // Assert
        Assert.Equal(30, bonus);
    }

    [Fact]
    public void GetStrikeBonus_ReturnsCorrectBonusForStrikeFollowedByNonStrike()
    {
        // Arrange
        string rolls = "X52--5/X5/";
        int nextFrameIndex = 1;

        // Act
        int bonus = StrikeBonus.GetStrikeBonus(rolls, nextFrameIndex);

        // Assert
        Assert.Equal(17, bonus);
    }
   

    [Fact]
    public void GetStrikeBonus_ReturnsCorrectBonusForStrikeFollowedBySpare1()
    {
        // Arrange
        string rolls = "X5/631/XX";
        int nextFrameIndex = 7;

        // Act
        int bonus = StrikeBonus.GetStrikeBonus(rolls, nextFrameIndex);

        // Assert
        Assert.Equal(30, bonus);
    }

    [Fact]
    public void GetStrikeBonus_ReturnsCorrectBonusForStrikeFollowedBySpare2()
    {
        // Arrange
        string rolls = "X5/1234";
        int nextFrameIndex = 1;

        // Act
        int bonus = StrikeBonus.GetStrikeBonus(rolls, nextFrameIndex);

        // Assert
        Assert.Equal(20, bonus);
    }

   

    [Fact]
    public void GetStrikeBonus_ReturnsCorrectBonusForStrikeFollowedByOpenFrame()
    {
        // Arrange
        string rolls = "X54234";
        int nextFrameIndex = 1;

        // Act
        int bonus = StrikeBonus.GetStrikeBonus(rolls, nextFrameIndex);

        // Assert
        Assert.Equal(19, bonus);
    }

    [Fact]
    public void GetStrikeBonus_ReturnsCorrectBonusForDoubleStrike()
    {
        // Arrange
        string rolls = "XX";
        int nextFrameIndex = 0;

        // Act
        int bonus = StrikeBonus.GetStrikeBonus(rolls, nextFrameIndex);

        // Assert
        Assert.Equal(30, bonus);
    }

    [Fact]
    public void GetStrikeBonus_ReturnsCorrectBonusForSpareFollowedByDoubleStrike()
    {
        // Arrange
        string rolls = "5/X";
        int nextFrameIndex = 0;

        // Act
        int bonus = StrikeBonus.GetStrikeBonus(rolls, nextFrameIndex);

        // Assert
        Assert.Equal(20, bonus);
    }

    [Fact]
    public void GetStrikeBonus_ReturnsCorrectBonusForSpareFollowedByStrikeAndNonStrike()
    {
        // Arrange
        string rolls = "5/X54321";
        int nextFrameIndex = 1;

        // Act
        int bonus = StrikeBonus.GetStrikeBonus(rolls, nextFrameIndex);

        // Assert
        Assert.Equal(20, bonus);
    }
}

