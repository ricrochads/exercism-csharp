namespace ExercismCSharp;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old) => old
        .SelectMany(keyValuePair => keyValuePair.Value.Select(value => new { Key = value.ToLower(), Value = keyValuePair.Key }))
        .ToDictionary(item => item.Key, item => item.Value);
}