using System.Text;
namespace ExercismCSharp;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        identifier = ReplaceSpacesWithUnderscores(identifier);
        identifier = ReplaceControlCharactersWithCTRL(identifier);
        identifier = ConvertKebabToCamelCase(identifier);
        identifier = OmitNonLetterCharacters(identifier);
        identifier = OmitGreekLettersInRange(identifier);

        return identifier;
    }

    private static string ReplaceSpacesWithUnderscores(string input)
    {
        StringBuilder stringBuilder = new StringBuilder(input.Length);

        foreach (char character in input)
        {
            switch (character)
            {
                case ' ':
                    stringBuilder.Append('_');
                    break;
                default:
                    stringBuilder.Append(character);
                    break;
            }   
        }
        
        return stringBuilder.ToString();
    }

    private static string ReplaceControlCharactersWithCTRL(string input)
    {
        StringBuilder stringBuilder = new StringBuilder(input.Length);

        foreach (char character in input)
        {
            if (char.IsControl(character))
                stringBuilder.Append("CTRL");
            else
                stringBuilder.Append(character);
        }
        
        return stringBuilder.ToString();
    }

    private static string OmitNonLetterCharacters(string input)
    {
        char[] result = new char[input.Length];
        int resultIndex = 0;

        foreach (char character in input)
        {
            if (char.IsLetter(character) || character == '_')
            {
                result[resultIndex] = character;
                resultIndex++;
            }
        }

        return new string(result, 0, resultIndex);
    }

    private static string ConvertKebabToCamelCase(string input)
    {
        string[] words = input.Split('-');

        for (int i = 1; i < words.Length; i++)
        {
            words[i] = char.ToUpper(words[i][0]) + words[i][1..];
        }

        return string.Join("", words);
    }

    private static string OmitGreekLettersInRange(string input)
    {
        string result = string.Empty;

        foreach (char character in input)
        {
            if (!IsGreekLowerCase(character))
                result += character;
        }

        return result;
    }

    static bool IsGreekLowerCase(char input)
    {
        return 'α' <= input && input <= 'ω';
    }
}