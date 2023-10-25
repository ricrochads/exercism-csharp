namespace ExercismCSharp;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        word = word.ToLower();
        HashSet<char> foundLetters = new();

        foreach (char letter in word)
        {
            if (foundLetters.Contains(letter))
                return false;
            else if (char.IsLetter(letter))
                foundLetters.Add(letter);
        }

        return true;
    }
}
