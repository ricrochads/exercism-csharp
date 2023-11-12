namespace ExercismCSharp;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        int index = Array.IndexOf(Colors(), color.ToLower().Trim());
        
        if (index == -1)
        {
            throw new ArgumentException($"The '{color}' is not a valid resistor color.");
        }

        return index;
    }

    public static string[] Colors() => new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
}