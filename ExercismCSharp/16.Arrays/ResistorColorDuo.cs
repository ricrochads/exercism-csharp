namespace ExercismCSharp;

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        string[] colorMap = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        
        int indexColor1 = Array.IndexOf(colorMap, colors[0]);
        int indexColor2 = Array.IndexOf(colorMap, colors[1]);

        int result = indexColor1 * 10 + indexColor2;

        return result;
    }
}