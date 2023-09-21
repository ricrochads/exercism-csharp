using Xunit;
namespace ExercismCSharp.Tests;

public class AssemblyLineTests
{
    [Fact]
    public void SuccessRate()
    {
        Assert.Equal(0, AssemblyLine.SuccessRate(0));

        Assert.Equal(1, AssemblyLine.SuccessRate(1));

        Assert.Equal(1, AssemblyLine.SuccessRate(2));

        Assert.Equal(1, AssemblyLine.SuccessRate(3));
        
        Assert.Equal(1, AssemblyLine.SuccessRate(4));

        Assert.Equal(0.9, AssemblyLine.SuccessRate(5));

        Assert.Equal(0.9, AssemblyLine.SuccessRate(6));

        Assert.Equal(0.9, AssemblyLine.SuccessRate(7));
        
        Assert.Equal(0.9, AssemblyLine.SuccessRate(8));
        
        Assert.Equal(0.8, AssemblyLine.SuccessRate(9));

        Assert.Equal(0.77, AssemblyLine.SuccessRate(10));
    }

    [Fact]
    public void ProductionRatePerHour()
    {
        Assert.Equal(0, AssemblyLine.ProductionRatePerHour(0));

        Assert.Equal(884, AssemblyLine.ProductionRatePerHour(4));

        Assert.Equal(1193.4, AssemblyLine.ProductionRatePerHour(6));

        Assert.Equal(1591.2, AssemblyLine.ProductionRatePerHour(8));

        Assert.Equal(1591.2, AssemblyLine.ProductionRatePerHour(9));

        Assert.Equal(1701,7, AssemblyLine.ProductionRatePerHour(10));
    }

    [Fact]
    public void WorkingItemsPerMinute()
    {
        Assert.Equal(0, AssemblyLine.WorkingItemsPerMinute(0));

        Assert.Equal(14, AssemblyLine.WorkingItemsPerMinute(4));

        Assert.Equal(19, AssemblyLine.WorkingItemsPerMinute(6));

        Assert.Equal(26, AssemblyLine.WorkingItemsPerMinute(8));

        Assert.Equal(26, AssemblyLine.WorkingItemsPerMinute(9));

        Assert.Equal(28, AssemblyLine.WorkingItemsPerMinute(10));
    }
}