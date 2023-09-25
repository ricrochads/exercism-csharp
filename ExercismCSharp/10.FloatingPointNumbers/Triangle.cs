namespace ExercismCSharp;

public static class Triangle
{
    private static bool IsValidTriangleSides(double side1, double side2, double side3)
    {
        return side1 > 0 && side2 > 0 && side3 > 0 && 
               side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2;
    }

    public static bool IsScalene(double side1, double side2, double side3)
    {
        if (IsValidTriangleSides(side1, side2, side3))
            return side1 != side2 && side1 != side3 && side2 != side3;
        return false;
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        if (IsValidTriangleSides(side1, side2, side3))
            return side1 == side2 || side1 == side3 || side2 == side3;
        return false;
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        if (IsValidTriangleSides(side1, side2, side3))
            return side1 == side2 && side1 == side3;
        return false;
    }
}