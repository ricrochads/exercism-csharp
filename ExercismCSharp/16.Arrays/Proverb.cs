namespace ExercismCSharp;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        if (subjects == null || subjects.Length == 0)
        {
            return Array.Empty<string>();
        }

        string[] proverbLines = new string[subjects.Length];

        for (int subject = 0; subject < subjects.Length - 1; subject++)
        {
            proverbLines[subject] = $"For want of a {subjects[subject]} the {subjects[subject + 1]} was lost.";
        }

        proverbLines[subjects.Length - 1] = $"And all for the want of a {subjects[0]}.";

        return proverbLines;
    }
}