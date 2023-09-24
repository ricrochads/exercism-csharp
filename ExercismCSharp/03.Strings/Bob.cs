namespace ExercismCSharp;

public static class Bob
{
    public static string Response(string statement)
    {
        var stmt = statement.TrimEnd();
        
        if (stmt == stmt.ToUpper() && stmt != stmt.ToLower() && stmt.EndsWith("?"))
            return "Calm down, I know what I'm doing!";
        if (stmt == stmt.ToUpper() && stmt != stmt.ToLower() && !stmt.EndsWith("?"))
            return"Whoa, chill out!";
        if (stmt.EndsWith("?"))
            return "Sure.";
        if (string.IsNullOrEmpty(stmt))
            return "Fine. Be that way!";
        else
            return "Whatever.";
    }
}