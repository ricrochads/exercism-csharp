using System.Runtime.InteropServices;

namespace ExercismCSharp;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment) => moment.AddSeconds(Math.Pow(10,9));
}