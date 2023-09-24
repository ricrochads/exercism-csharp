namespace ExercismCSharp;

public static class SavingsAccount
{
    static float negativeBalanceInterestRate = 3.213f;
    static float lowPositiveBalanceInterestRate = 0.5f;
    static float mediumPositiveBalanceInterestRate = 1.621f;
    static float highPositiveBalanceInterestRate = 2.475f;

    public static float InterestRate(decimal balance)
    {
        switch (balance)
        {
            case < 0:
                return negativeBalanceInterestRate;
            case < 1000:
                return lowPositiveBalanceInterestRate;
            case < 5000:
                return mediumPositiveBalanceInterestRate;
            case >= 5000:
                return highPositiveBalanceInterestRate;
            default:
        }
    }

    public static decimal Interest(decimal balance)
    {
        return balance * Convert.ToDecimal(InterestRate(balance)/100);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
    }
}