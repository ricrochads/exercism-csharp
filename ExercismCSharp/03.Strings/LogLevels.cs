namespace ExercismCSharp;

public static class LogLine
{
    public static string Message(string logLine)
    {
        string[] message = logLine.Split(new char[] {':'}, 2);
        return message[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        string[] logLevel = logLine.Split(new char[] {':'}, 2);
        return logLevel[0].Trim('[', ']').ToLower();
    }

    public static string Reformat(string logLine)
    {
        string logLevel = LogLevel(logLine);
        string message = Message(logLine);

        string reformattedLogLine = $"{message} ({logLevel})";

        return reformattedLogLine;
    }
}