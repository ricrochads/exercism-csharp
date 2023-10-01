namespace ExercismCSharp;

public class RemoteControlVehicle
{
    private int _speed;
    private int _batteryDrain;
    private int _batteryCharge;
    private int _distanceDriven;

    public RemoteControlVehicle(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
        _batteryCharge = 100;
    }

    public bool BatteryDrained()
    {
        return _batteryCharge < _batteryDrain;
    }

    public int DistanceDriven()
    {
       return _distanceDriven;
    }

    public void Drive()
    {
        if (BatteryDrained() == false)
        {
            _distanceDriven += _speed;
            _batteryCharge -= _batteryDrain;
        }
    }

    public static RemoteControlVehicle Nitro()
    {
        return new RemoteControlVehicle(50, 4);
    }
}

public class RaceTrack
{
    private int _distance;

    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlVehicle car)
    {
        while (car.BatteryDrained() == false)
        {
            car.Drive();
        }
        return car.DistanceDriven() >= _distance;
    }
}