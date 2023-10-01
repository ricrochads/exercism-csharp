using Xunit;
namespace ExercismCSharp.Tests;

public class RemoteControlCarTests
{
    [Fact]
    public void BuyNewCar_ReturnsInstance()
    {
        var car = RemoteControlCar.Buy();
        Assert.NotNull(car);
    }

    [Fact]
    public void BuyNewCar_ReturnsNewCarEachTime()
    {
        var car1 = RemoteControlCar.Buy();
        var car2 = RemoteControlCar.Buy();
        Assert.NotSame(car1, car2);
    }

    [Fact]
    public void NewCarDistanceDisplay_ShowsDistance()
    {
        var car = new RemoteControlCar();
        Assert.Equal("Driven 0 meters", car.DistanceDisplay());
    }

    [Fact]
    public void NewCarBatteryDisplay_ShowsBattery()
    {
        var car = new RemoteControlCar();
        Assert.Equal("Battery at 100%", car.BatteryDisplay());
    }

    [Fact]
    public void DistanceDisplay_AfterDrivingOnce()
    {
        var car = new RemoteControlCar();
        car.Drive();
        Assert.Equal("Driven 20 meters", car.DistanceDisplay());
    }

    [Fact]
    public void DistanceDisplay_AfterDrivingMultipleTimes()
    {
        var car = new RemoteControlCar();
        for (var i = 0; i < 17; i++)
        {
            car.Drive();
        }
        Assert.Equal("Driven 340 meters", car.DistanceDisplay());
    }

    [Fact]
    public void BatteryDisplay_AfterDrivingOnce()
    {
        var car = new RemoteControlCar();
        car.Drive();
        Assert.Equal("Battery at 99%", car.BatteryDisplay());
    }

    [Fact]
    public void BatteryDisplay_AfterDrivingMultipleTimes()
    {
        var car = new RemoteControlCar();
        for (var i = 0; i < 23; i++)
        {
            car.Drive();
        }
        Assert.Equal("Battery at 77%", car.BatteryDisplay());
    }

    [Fact]
    public void BatteryDisplay_WhenBatteryEmpty()
    {
        var car = new RemoteControlCar();
        for (var i = 0; i < 100; i++)
        {
            car.Drive();
        }
        car.Drive();
        Assert.Equal("Battery empty", car.BatteryDisplay());
    }

    [Fact]
    public void DistanceDisplay_WhenBatteryEmpty()
    {
        var car = new RemoteControlCar();
        for (var i = 0; i < 100; i++)
        {
            car.Drive();
        }
        car.Drive();
        Assert.Equal("Driven 2000 meters", car.DistanceDisplay());
    }
}