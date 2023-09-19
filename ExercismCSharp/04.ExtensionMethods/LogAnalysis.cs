namespace ExercismCSharp;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimiter)
    {
        int delimiterIndex  = str.IndexOf(delimiter) + delimiter.Length;
        return str.Substring(delimiterIndex , str.Length - delimiterIndex);
    }

    public static string SubstringBetween(this string str, string start, string end)
    {
        int startIndex = str.IndexOf(start) + start.Length;
        int endIndex = str.IndexOf(end, startIndex) - startIndex;
        return str.Substring(startIndex, endIndex);
    }

    public static string Message(this string str, string delimiter)
    {
        return str.SubstringAfter(delimiter);
    }

    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }
}