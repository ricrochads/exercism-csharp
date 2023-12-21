using Xunit;
namespace ExercismCSharp.Tests;

public class SimpleCalculatorTests
{
    [Fact]
    public void CalculatorOperations_AdditionWithSmallOperands()
    {
        Assert.Equal("22 + 25 = 47", SimpleCalculator.Calculate(22, 25, "+"));
    }

    [Fact]
    public void CalculatorOperations_AdditionWithLargeOperands()
    {
        Assert.Equal("378961 + 399635 = 778596", SimpleCalculator.Calculate(378_961, 399_635, "+"));
    }

    [Fact]
    public void CalculatorOperations_MultiplicationWithSmallOperands()
    {
        Assert.Equal("3 * 21 = 63", SimpleCalculator.Calculate(3, 21, "*"));
    }

    [Fact]
    public void CalculatorOperations_MultiplicationWithLargeOperands()
    {
        Assert.Equal("72441 * 2048 = 148359168", SimpleCalculator.Calculate(72_441, 2_048, "*"));
    }

    [Fact]
    public void CalculatorOperations_DivisionWithSmallOperands()
    {
        Assert.Equal("72 / 9 = 8", SimpleCalculator.Calculate(72, 9, "/"));
    }

    [Fact]
    public void HandleIllegalOperations_CalculateThrowsExceptionForNonValidOperations()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => SimpleCalculator.Calculate(1, 2, "**"));
    }

    [Fact]
    public void HandleIllegalOperations_CalculateThrowsExceptionForNullAsOperation()
    {
        Assert.Throws<ArgumentNullException>(() => SimpleCalculator.Calculate(1, 2, null));
    }

    [Fact]
    public void HandleIllegalOperations_CalculateThrowsExceptionForEmptyStringAsOperation()
    {
        Assert.Throws<ArgumentException>(() => SimpleCalculator.Calculate(1, 2, ""));
    }

    [Fact]
    public void HandleErrorsWhenDividingByZero_CalculateThrowsExceptionForDivisionWithZero()
    {
        Assert.Equal("Division by zero is not allowed.", SimpleCalculator.Calculate(33, 0, "/"));
    }
}