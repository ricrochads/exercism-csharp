namespace ExercismCSharp;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = max * (max + 1) / 2;
        int squareOfSum = sum * sum;
        
        return squareOfSum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int sumOfSquares = max * (max + 1) * (2 * max + 1) / 6;
        
        return sumOfSquares;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        int differenceOfSquares = CalculateSquareOfSum(max) - CalculateSumOfSquares(max);

        return differenceOfSquares;
    }
}