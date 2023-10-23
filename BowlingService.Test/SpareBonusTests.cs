namespace BowlingService.Test;

public class SpareBonusTests
{
    [Fact]
    public void GetSpareBonus_ReturnsCorrectBonusForSpareFollowedByStrike()
    {
        // Arrange
        string rolls = "5/X";

        // Act
        int bonus = SpareBonus.GetSpareBonus(rolls, 2);

        // Assert
        Assert.Equal(20, bonus);
    }  

    [Fact]
    public void GetSpareBonus_ReturnsCorrectBonusForSpareFollowedByNonStrike()
    {
        // Arrange
        string rolls = "9/-";

        // Act
        int bonus = SpareBonus.GetSpareBonus(rolls, 2);

        // Assert
        Assert.Equal(10, bonus);
    }

    [Fact]
    public void GetSpareBonus_ReturnsCorrectBonusForStrikeFollowedBySpare()
    {
        // Arrange
        string rolls = "X5/";
        int nextRollIndex = 0;

        // Act
        int bonus = SpareBonus.GetSpareBonus(rolls, nextRollIndex);

        // Assert
        Assert.Equal(20, bonus);
    }

    [Fact]
    public void GetSpareBonus_ReturnsCorrectBonusForSpareFollowedByOpenFrame()
    {
        // Arrange
        string rolls = "9/5-";
        int nextRollIndex = 2;

        // Act
        int bonus = SpareBonus.GetSpareBonus(rolls, nextRollIndex);

        // Assert
        Assert.Equal(15, bonus);
    }

    [Fact]
    public void GetSpareBonus_ReturnsCorrectBonusForSpareFollowedByStrikeAndOpenFrame()
    {
        // Arrange
        string rolls = "9/X5-";
        int nextRollIndex = 2;

        // Act
        int bonus = SpareBonus.GetSpareBonus(rolls, nextRollIndex);

        // Assert
        Assert.Equal(20, bonus);
    }

    [Fact]
    public void GetSpareBonus_ReturnsCorrectBonusForSpareFollowedByOneStrike()
    {
        // Arrange
        string rolls = "9/X-";
        int nextRollIndex = 2;

        // Act
        int bonus = SpareBonus.GetSpareBonus(rolls, nextRollIndex);

        // Assert
        Assert.Equal(20, bonus);
    }   

    [Fact]
    public void GetSpareBonus_ReturnsCorrectBonusForSpareFollowedByStrikeAndNonStrike()
    {
        // Arrange
        string rolls = "9/X5";
        int nextRollIndex = 2;

        // Act
        int bonus = SpareBonus.GetSpareBonus(rolls, nextRollIndex);

        // Assert
        Assert.Equal(20, bonus);
    }

    [Fact]
    public void GetSpareBonus_ReturnsCorrectBonusForSpareFollowedByTwoNonStrikes()
    {
        // Arrange
        string rolls = "9/5";
        int nextRollIndex = 2;

        // Act
        int bonus = SpareBonus.GetSpareBonus(rolls, nextRollIndex);

        // Assert
        Assert.Equal(15, bonus);
    }
}

