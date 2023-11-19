namespace ExercismCSharp;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum) => shirtNum switch
    {
        1 => "goalie",
        2 => "left back",
        3 or 4 => "center back",
        5 => "right back",
        6 or 7 or 8 => "midfielder",
        9 => "left wing",
        10 => "striker",
        11 => "right wing",
        _ => throw new ArgumentOutOfRangeException($"Unexpected shirt number: {shirtNum}")
    };

    public static string AnalyzeOffField(object report) => report switch
    {
        int => $"There are {report} supporters at the match.",
        string => $"{report}",
        Incident incident when incident is not null => incident.GetDescription(),
        Manager manager when manager.Club is not null => manager.Description,
        Manager manager => manager.Name,
        _ => throw new ArgumentException("Unsupported data type."),
    };
}

public class Incident
{
    public virtual string GetDescription() => "An incident happened.";
}

public class Foul : Incident
{
    public override string GetDescription() => "The referee deemed a foul.";
}

public class Injury : Incident
{
    private readonly int playerNumber;
    
    public Injury(int playerNumber) => this.playerNumber = playerNumber;

    public override string GetDescription() => $"Oh no! Player {playerNumber} is injured. Medics are on the field.";
}

public class Manager
{
    public string Name { get; }
    public string? Club { get; }
    public string Description { get; set; }

    public Manager(string name, string? club)
    {
        Name = name;
        Club = club;
        Description = $"{name} ({club})";
    }
}