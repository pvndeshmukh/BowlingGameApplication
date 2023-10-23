namespace BowlingService.Test;

public class EnumTests
{
    [Fact]
    public void BonusEnum_HasCorrectTenValue()
    {
        // Act
        int tenValue = (int)Bonus.Ten;

        // Assert
        Assert.Equal(10, tenValue);
    }

    [Fact]
    public void BonusEnum_TenIsNotNine()
    {
        // Act
        int tenValue = (int)Bonus.Ten;

        // Assert
        Assert.NotEqual(9, tenValue);
    }

    [Fact]
    public void BonusEnum_TenIsNotEleven()
    {
        // Act
        int tenValue = (int)Bonus.Ten;

        // Assert
        Assert.NotEqual(11, tenValue);
    }

    [Fact]
    public void FramesEnum_HasCorrectStartValue()
    {
        // Act
        int startValue = (int)Frames.Start;

        // Assert
        Assert.Equal(1, startValue);
    }

    [Fact]
    public void FramesEnum_HasCorrectEndValue()
    {
        // Act
        int endValue = (int)Frames.End;

        // Assert
        Assert.Equal(10, endValue);
    }

    [Fact]
    public void FramesEnum_StartIsNotTen()
    {
        // Act
        int startValue = (int)Frames.Start;

        // Assert
        Assert.NotEqual(10, startValue);
    }

    [Fact]
    public void FramesEnum_EndIsNotOne()
    {
        // Act
        int endValue = (int)Frames.End;

        // Assert
        Assert.NotEqual(1, endValue);
    }
}
