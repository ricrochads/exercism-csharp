namespace ExercismCSharp;

public static class Darts
{
    static int noPoints = 0;
    static int outerCirclePoints = 1;
    static int centerCirclePoints = 5;
    static int innerCirclePoints = 10;

    public static int Score(double x, double y)
    {
        double distanceToCenter = Math.Pow(Math.Pow(x, 2) + Math.Pow(y, 2), 0.5);

        if (distanceToCenter <= 1)
            return innerCirclePoints;
        if (distanceToCenter <= 5)
            return centerCirclePoints;
        if (distanceToCenter <= 10)
            return outerCirclePoints;
        else
            return noPoints;
    }
}