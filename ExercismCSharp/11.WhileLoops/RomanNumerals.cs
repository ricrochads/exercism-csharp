using System.Text;
namespace ExercismCSharp;

public static class RomanNumeralExtension
{
    private static readonly (string Symbol, int NumeralValue)[] RomanNumerals =
    {
        ("I", 1), ("IV", 4), ("V", 5), ("IX", 9),
        ("X", 10), ("XL", 40), ("L", 50), ("XC", 90),
        ("C", 100), ("CD", 400), ("D", 500), ("CM", 900), 
        ("M", 1000)
    };

    public static string ToRoman(this int value)
     {
        if (value <= 0 || value >= 4000)
            return string.Empty;
            
        StringBuilder result = new();
        
        foreach (var numeral in RomanNumerals.OrderByDescending(rn => rn.NumeralValue))
        {
            while (value >= numeral.NumeralValue)
            {
                result.Append(numeral.Symbol);
                value -= numeral.NumeralValue;
            }
        }
        return result.ToString();
    }
}