using Xunit;
namespace ExercismCSharp.Tests;

public class LeapTests
{
    [Fact]
    public void IsLeapYear()
    {
        Assert.True(Leap.IsLeapYear(2020));

        Assert.True(Leap.IsLeapYear(2016));

        Assert.True(Leap.IsLeapYear(2012));

        Assert.True(Leap.IsLeapYear(2008));

        Assert.True(Leap.IsLeapYear(2004));

        Assert.False(Leap.IsLeapYear(2023));

        Assert.False(Leap.IsLeapYear(2022));
        
        Assert.False(Leap.IsLeapYear(2021));

        Assert.False(Leap.IsLeapYear(2019));

        Assert.False(Leap.IsLeapYear(2018));
    }
}