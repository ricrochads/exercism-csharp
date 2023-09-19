using Xunit;
namespace ExercismCSharp.Tests;

public class LogAnalysisTests
{
    [Fact]
    public void SubstringAfter()
    {
        var str = "[INFO]: File Deleted.";
        Assert.Equal("File Deleted.", LogAnalysis.SubstringAfter(str, ": "));

        str = "[WARNING]: This is an important warning.";
        Assert.Equal("This is an important warning.", LogAnalysis.SubstringAfter(str, ": "));

        str = "[ERROR]: Missing ; on line 20.";
        Assert.Equal("Missing ; on line 20.", LogAnalysis.SubstringAfter(str, ": "));
    }

    [Fact]
    public void SubstringBetween()
    {
        var str = "[INFO]: File Deleted.";
        Assert.Equal("INFO", LogAnalysis.SubstringBetween(str, "[", "]"));

        str = "[WARNING]: This is an important warning.";
        Assert.Equal("WARNING", LogAnalysis.SubstringBetween(str, "[", "]"));

        str = "[ERROR]: Missing ; on line 20.";
        Assert.Equal("ERROR", LogAnalysis.SubstringBetween(str, "[", "]"));
    }

    [Fact]
    public void Message()
    {
        var str = "[INFO]: File Deleted.";
        Assert.Equal("File Deleted.", LogAnalysis.Message(str, ": "));

        str = "[WARNING]: This is an important warning.";
        Assert.Equal("This is an important warning.", LogAnalysis.Message(str, ": "));

        str = "[ERROR]: Missing ; on line 20.";
        Assert.Equal("Missing ; on line 20.", LogAnalysis.Message(str, ": "));
    }

    [Fact]
    public void LogLevel()
    {
        var str = "[INFO]: File Deleted.";
        Assert.Equal("INFO", LogAnalysis.LogLevel(str));

        str = "[WARNING]: This is an important warning.";
        Assert.Equal("WARNING", LogAnalysis.LogLevel(str));

        str = "[ERROR]: Missing ; on line 20.";
        Assert.Equal("ERROR", LogAnalysis.LogLevel(str));
    }
}