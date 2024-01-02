using Xunit;
namespace ExercismCSharp.Tests;

public class CentralBankTests
{
    [Fact]
    public void DisplayDenomination_Good()
    {
        Assert.Equal("10000000", CentralBank.DisplayDenomination(10000L, 1000L));
    }

    [Fact]
    public void DisplayDenomination_Bad()
    {
        Assert.Equal("*** Too Big ***", CentralBank.DisplayDenomination(long.MaxValue / 2L, 10000L));
    }

    [Fact]
    public void DisplayGDP_Good()
    {
        Assert.Equal("5550000", CentralBank.DisplayGDP(555f, 10000f));
    }

    [Fact]
    public void DisplayGDP_Bad()
    {
        Assert.Equal("*** Too Big ***", CentralBank.DisplayGDP(float.MaxValue / 2L, 10000f));
    }

    [Fact]
    public void DisplaySalary_Good()
    {
        Assert.Equal("5550000000", CentralBank.DisplayChiefEconomistSalary(555000m, 10000m));
    }

    [Fact]
    public void DisplaySalary_Bad()
    {
        Assert.Equal("*** Much Too Big ***", CentralBank.DisplayChiefEconomistSalary(555000m, decimal.MaxValue / 2L));
    }
}