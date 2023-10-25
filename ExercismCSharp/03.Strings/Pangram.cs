namespace ExercismCSharp;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        input = input.ToLower();
        HashSet<char> alphabet = new("abcdefghijklmnopqrstuvwxyz");

        foreach (char letter in alphabet)
        {
            if (!input.Contains(letter))
                return false;
        }

        return true;
    }
}