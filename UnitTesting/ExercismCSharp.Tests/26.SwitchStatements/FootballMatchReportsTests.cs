using Xunit;
namespace ExercismCSharp.Tests;

public class PlayAnalyzerTests
{
    [Fact]
    public void AnalyzeOnField_Number1()
    {
        Assert.Equal("goalie", PlayAnalyzer.AnalyzeOnField(1));
    }

    [Fact]
    public void AnalyzeOnField_Number8()
    {
        Assert.Equal("midfielder", PlayAnalyzer.AnalyzeOnField(8));
    }

    [Fact]
    public void AnalyzeOnField_Number10()
    {
        Assert.Equal("striker", PlayAnalyzer.AnalyzeOnField(10));
    }

    [Fact]
    public void AnalyzeOnField_Number11()
    {
        Assert.Equal("right wing", PlayAnalyzer.AnalyzeOnField(11));
    }

    [Fact]
    public void AnalyzeOnField_UnknowShirtNumber()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => PlayAnalyzer.AnalyzeOnField(1729));
    }

    [Fact]
    public void AnalyzeOffField_Number()
    {
        Assert.Equal("There are 4200 supporters at the match.", PlayAnalyzer.AnalyzeOffField(4200));
    }

    [Fact]
    public void AnalyzeOffField_ThrowsUnknowType()
    {
        Assert.Throws<ArgumentException>(() => PlayAnalyzer.AnalyzeOffField(90.0f));
    }

    [Fact]
    public void AnalyzeOffField_Text()
    {
        Assert.Equal("They think it's all over!", PlayAnalyzer.AnalyzeOffField("They think it's all over!"));
    }

    [Fact]
    public void AnalyzeOffField_Incident()
    {
        Assert.Equal("An incident happened.", PlayAnalyzer.AnalyzeOffField(new Incident()));
    }

    [Fact]
    public void AnalyzeOffField_Foul()
    {
        Assert.Equal("The referee deemed a foul.", PlayAnalyzer.AnalyzeOffField(new Foul()));
    }

    [Fact]
    public void AnalyzeOffField_Injury()
    {
        Assert.Equal("Oh no! Player 3 is injured. Medics are on the field.", PlayAnalyzer.AnalyzeOffField(new Injury(3)));
    }

    [Fact]
    public void AnalyzeOffField_ManagerNoClub()
    {
        Assert.Equal("David Moyes", PlayAnalyzer.AnalyzeOffField(new Manager("David Moyes", null)));
    }

    [Fact]
    public void AnalyzeOffField_ManagerWithClub()
    {
        Assert.Equal("Thomas Tuchel (Chelsea)", PlayAnalyzer.AnalyzeOffField(new Manager("Thomas Tuchel", "Chelsea")));
    }
}
