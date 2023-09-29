using Xunit;
namespace ExercismCSharp.Tests;

public class RollTheDieTests
{
    [Fact]
    public void RollDie_ReturnsRandomNumberInRange()
    {
        int min = 1;
        int max = 18;
        int result = Player.RollDie();
        Assert.InRange(result, min, max);
    }

    [Fact]
    public void GenerateSpellStrength_ReturnsRandomNumberWithDecimalPart()
    {
        double result = Player.GenerateSpellStrength();
        Assert.True(result >= 0 && result < 100);
        Assert.True(result % 1 != 0);
    }
}