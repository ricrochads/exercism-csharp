using Xunit;
namespace ExercismCSharp.Tests;

public class LuciansLusciousLasagnaTests
{
    [Fact]
    public void ExpectedMinutesInOven()
    {
        var lasagna = new Lasagna();
        Assert.Equal(40, lasagna.ExpectedMinutesInOven());
    } 

    [Fact]
    public void RemainingMinutesInOven()
    {
        var lasagna = new Lasagna();
        Assert.Equal(10, lasagna.RemainingMinutesInOven(30));
    } 

    [Fact]
    public void PreparationTimeInMinutes()
    {
        var lasagna = new Lasagna();
        Assert.Equal(4, lasagna.PreparationTimeInMinutes(2));
    }

    [Fact]
    public void ElapsedTimeInMinutes()
    {
        var lasagna = new Lasagna();
        Assert.Equal(26, lasagna.ElapsedTimeInMinutes(3, 20));
    }
}