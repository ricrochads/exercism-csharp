using Xunit;
namespace ExercismCSharp.Tests;

public class RemoteControlVehicleTests
{
    [Fact]
    public void NewRemoteControlVehicle_HasNotDrivenAnyDistance()
    {
        int speed = 10;
        int batteryDrain = 2;
        var car = new RemoteControlVehicle(speed, batteryDrain);
        Assert.Equal(0, car.DistanceDriven());
    }

    [Fact]
    public void Drive_IncreasesDistanceDrivenWithSpeed()
    {
        int speed = 5;
        int batteryDrain = 1;
        var car = new RemoteControlVehicle(speed, batteryDrain);
        car.Drive();
        Assert.Equal(5, car.DistanceDriven());
    }

    [Fact]
    public void Drive_DoesNotIncreaseDistanceWhenBatteryDrained()
    {
        int speed = 9;
        int batteryDrain = 50;
        var car = new RemoteControlVehicle(speed, batteryDrain);
        car.Drive();
        car.Drive();
        car.Drive();
        Assert.Equal(18, car.DistanceDriven());
    }

    [Fact]
    public void NewRemoteControlCar_BatteryIsNotDrained()
    {
        int speed = 15;
        int batteryDrain = 3;
        var car = new RemoteControlVehicle(speed, batteryDrain);
        Assert.False(car.BatteryDrained());
    }

    [Fact]
    public void Drive_ToAlmostDrainBattery()
    {
        int speed = 2;
        int batteryDrain = 1;
        var car = new RemoteControlVehicle(speed, batteryDrain);
        for (var i = 0; i < 99; i++)
        {
            car.Drive();
        }
        Assert.False(car.BatteryDrained());
    }

    [Fact]
    public void Drive_UntilBatteryIsDrained()
    {
        int speed = 2;
        int batteryDrain = 1;
        var car = new RemoteControlVehicle(speed, batteryDrain);
        for (var i = 0; i < 100; i++)
        {
            car.Drive();
        }
        Assert.True(car.BatteryDrained());
    }

    [Fact]
    public void SuperHungryCar_AfterOneDrive_IsDrained()
    {
        int speed = 100;
        int batteryDrain = 60;
        var car = new RemoteControlVehicle(speed, batteryDrain);
        car.Drive();
        Assert.True(car.BatteryDrained());
    }

    [Fact]
    public void SuperHungryCar_CanTryDriving_ButIsDrained()
    {
        int speed = 100;
        int batteryDrain = 60;
        var car = new RemoteControlVehicle(speed, batteryDrain);
        car.Drive();
        car.Drive();
        Assert.True(car.BatteryDrained());
        Assert.Equal(100, car.DistanceDriven());
    }

    [Fact]
    public void NitroCar_HasNotDrivenAnyDistance()
    {
        var car = RemoteControlVehicle.Nitro();
        Assert.Equal(0, car.DistanceDriven());
    }

    [Fact]
    public void NitroCar_BatteryNotDrained()
    {
        var car = RemoteControlVehicle.Nitro();
        Assert.False(car.BatteryDrained());
    }

    [Fact]
    public void NitroCar_HasCorrectSpeed()
    {
        var car = RemoteControlVehicle.Nitro();
        car.Drive();
        Assert.Equal(50, car.DistanceDriven());
    }

    [Fact]
    public void NitroCar_HasCorrectBatteryDrain()
    {
        var car = RemoteControlVehicle.Nitro();
        for (var i = 0; i < 24; i++)
        {
            car.Drive();
        }
        Assert.False(car.BatteryDrained());
        car.Drive();
        Assert.True(car.BatteryDrained());
    }

    [Fact]
    public void CarCanFinish_WithCarThatCanEasilyFinish()
    {
        int speed = 10;
        int batteryDrain = 2;
        var car = new RemoteControlVehicle(speed, batteryDrain);
        int distance = 100;
        var race = new RaceTrack(distance);
        Assert.True(race.TryFinishTrack(car));
    }

    [Fact]
    public void CarCanFinish_WithCarThatCanJustFinish()
    {
        int speed = 2;
        int batteryDrain = 10;
        var car = new RemoteControlVehicle(speed, batteryDrain);
        int distance = 20;
        var race = new RaceTrack(distance);
        Assert.True(race.TryFinishTrack(car));
    }

    [Fact]
    public void CarCanFinish_WithCarThatJustCannotFinish()
    {
        int speed = 3;
        int batteryDrain = 20;
        var car = new RemoteControlVehicle(speed, batteryDrain);
        int distance = 16;
        var race = new RaceTrack(distance);
        Assert.False(race.TryFinishTrack(car));
    }

    [Fact]
    public void CarCanFinish_WithCarThatCannotFinish()
    {
        int speed = 1;
        int batteryDrain = 20;
        var car = new RemoteControlVehicle(speed, batteryDrain);
        int distance = 678;
        var race = new RaceTrack(distance);
        Assert.False(race.TryFinishTrack(car));
    }
}