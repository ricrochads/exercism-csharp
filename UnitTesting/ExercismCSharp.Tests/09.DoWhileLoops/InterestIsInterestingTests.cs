using Xunit;
namespace ExercismCSharp.Tests;

public class SavingsAccountTests
{
    decimal balance = 200.75m;

    [Fact]
    public void Calculate_the_interest_rate()
    {
        Assert.Equal(0.5f, SavingsAccount.InterestRate(balance));
    }

    [Fact]
    public void Calculate_the_interest()
    {
        Assert.Equal(1.00375m, SavingsAccount.Interest(balance));
    }

    [Fact]
    public void Calculate_the_annual_balance_update()
    {
        Assert.Equal(201.75375m, SavingsAccount.AnnualBalanceUpdate(balance));
    }

    [Fact]
    public void Calculate_the_years_before_reaching_the_desired_balance()
    {
        Assert.Equal(14, SavingsAccount.YearsBeforeDesiredBalance(balance, 214.88m));
    }
}