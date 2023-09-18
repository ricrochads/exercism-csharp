using Xunit;
namespace ExercismCSharp.Tests;

public class LogLevelsTests
{
    [Fact]
    public void Message()
    {
        var logLine = "[ERROR]: Invalid operation";
        Assert.Equal("Invalid operation", LogLine.Message(logLine));

        logLine = "[WARNING]:  Disk almost full\r\n";
        Assert.Equal("Disk almost full", LogLine.Message(logLine));
    }

    [Fact]
    public void LogLevel()
    {
        var logLine = "[ERROR]: Invalid operation";
        Assert.Equal("error", LogLine.LogLevel(logLine));
    }

    [Fact]
    public void Reformat()
    {
        var logLine = "[INFO]: Operation completed";
        Assert.Equal("Operation completed (info)", LogLine.Reformat(logLine));
    }
}