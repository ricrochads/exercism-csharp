namespace ExercismCSharp;

public static class AssemblyLine
{
    const int carsProducedPerHour = 221;

    public static double SuccessRate(int speed)
    {
        if (speed == 0)
            return 0;
        if (speed <= 4)
            return 1;
        if (speed <= 8)
            return 0.9;
        if (speed == 9)
            return 0.8;
        else
            return 0.77;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return SuccessRate(speed) * speed * carsProducedPerHour;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)(ProductionRatePerHour(speed) / 60);
    }
}