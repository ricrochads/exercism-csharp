namespace ExercismCSharp;

public static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if (id != null && department != null)
            return $"[{id}] - {name} - {department.ToUpper()}";
        if (id == null && department != null)
            return $"{name} - {department.ToUpper()}";
        if (id != null && department == null)
            return $"[{id}] - {name} - OWNER";
        else
            return $"{name} - OWNER";
    }
}