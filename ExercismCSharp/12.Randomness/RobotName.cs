namespace ExercismCSharp;

public class Robot
{
    private static readonly Random random = new();
    private static readonly HashSet<string> usedNames = new();

    public string Name { get; private set; } = string.Empty;

    public Robot() => Reset();

    public void Reset() => Name = GenerateName();

    private static string GenerateName()
    {
        string name;

        do
        {
            string letters = new(Enumerable.Range(0, 2).Select(_ => (char)random.Next('A', 'Z' + 1)).ToArray());
            string digits = new(Enumerable.Range(0, 3).Select(_ => random.Next(0, 10).ToString()[0]).ToArray());
            name = $"{letters}{digits}";
        }while (usedNames.Contains(name));

        usedNames.Add(name);
        return name;
    }
}