using Xunit;
namespace ExercismCSharp.Tests;

public class ResistorColorTests
{
    [Fact]
    public void ColorCode_Black_ShouldReturnZero()
    {
        Assert.Equal(0, ResistorColor.ColorCode("black"));
    }

    [Fact]
    public void ColorCode_Brown_ShouldReturnOne()
    {
        Assert.Equal(1, ResistorColor.ColorCode("Brown"));
    }

    [Fact]
    public void ColorCode_Red_ShouldReturnTwo()
    {
        Assert.Equal(2, ResistorColor.ColorCode("rEd"));
    }

    [Fact]
    public void ColorCode_Orange_ShouldReturnThree()
    {
        Assert.Equal(3, ResistorColor.ColorCode("OrAnGe"));
    }

    [Fact]
    public void ColorCode_Yellow_ShouldReturnFour()
    {
        Assert.Equal(4, ResistorColor.ColorCode(" yellow"));
    }

    [Fact]
    public void ColorCode_Green_ShouldReturnFive()
    {
        Assert.Equal(5, ResistorColor.ColorCode("green "));
    }

    [Fact]
    public void ColorCode_Blue_ShouldReturnSix()
    {
        Assert.Equal(6, ResistorColor.ColorCode(" blue "));
    }

    [Fact]
    public void ColorCode_Violet_ShouldReturnSeven()
    {
        Assert.Equal(7, ResistorColor.ColorCode("VIOLET"));
    }

    [Fact]
    public void ColorCode_Grey_ShouldReturnEight()
    {
        Assert.Equal(8, ResistorColor.ColorCode("greY"));
    }

    [Fact]
    public void ColorCode_White_ShouldReturnNine()
    {
        Assert.Equal(9, ResistorColor.ColorCode("white"));
    }

    [Fact]
    public void Colors()
    {
        Assert.Equal(new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" }, ResistorColor.Colors());
    }

    [Fact]
    public void ColorCode_InvalidColor_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => ResistorColor.ColorCode("color"));
    }
}