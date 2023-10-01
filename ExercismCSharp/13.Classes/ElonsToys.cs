namespace ExercismCSharp;

public class RemoteControlCar
{
    private int _distanceDriven = 0;
    private int _batteryCharge = 100;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {        
        return $"Driven {_distanceDriven} meters"; 
    }

    public string BatteryDisplay()
    {
        return _batteryCharge == 0 ? "Battery empty" : $"Battery at {_batteryCharge}%";
    }

    public void Drive()
    {
        if(_batteryCharge != 0)
        {
            _distanceDriven += 20;
            _batteryCharge -= 1;
        }
    }
}