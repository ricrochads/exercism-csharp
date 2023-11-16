namespace ExercismCSharp;

public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary() => new();

    public static Dictionary<int, string> GetExistingDictionary() => new()
    {
        { 1, "United States of America" },
        { 55, "Brazil" },
        { 91, "India" }
    };

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        Dictionary<int, string> dictionary = new()
        {
            { countryCode, countryName }
        };
        return dictionary;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (!existingDictionary.ContainsKey(countryCode))
        {
            existingDictionary.Add(countryCode, countryName);
        }
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (existingDictionary.TryGetValue(countryCode, out var countryName))
        {
            return countryName;
        }
        return string.Empty;
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode);
    }

    public static Dictionary<int, string> UpdateDictionary(Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (existingDictionary.ContainsKey(countryCode))
        {
            existingDictionary[countryCode] = countryName;
        }
        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        var longestCountryName = existingDictionary.Values.Aggregate("", (max, cur) => cur.Length > max.Length ? cur : max);
        return longestCountryName;
    }
}