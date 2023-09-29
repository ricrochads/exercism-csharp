namespace ExercismCSharp;

public class Player
{
    public static int RollDie()
    {
        return Random.Shared.Next(1,18);
    }

    public static double GenerateSpellStrength()
    {
        return Random.Shared.NextDouble() + Random.Shared.Next(0, 99);
    }
}