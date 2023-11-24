using Xunit;
namespace ExercismCSharp.Tests;

public class LogLinesTests
{
    [Fact]
    public void ParseLogLevel_ParseTrace()
    {
        Assert.Equal(LogLevel.Trace, LogLines.ParseLogLevel("[TRC]: Line 84 - Console.WriteLine('Hello World');"));
    }

    [Fact]
    public void ParseLogLevel_ParseDebug()
    {
        Assert.Equal(LogLevel.Debug, LogLines.ParseLogLevel("[DBG]: ; expected"));
    }

    [Fact]
    public void ParseLogLevel_ParseInfo()
    {
        Assert.Equal(LogLevel.Info, LogLines.ParseLogLevel("[INF]: Timezone changed"));
    }

    [Fact]
    public void ParseLogLevel_ParseWarning()
    {
        Assert.Equal(LogLevel.Warning, LogLines.ParseLogLevel("[WRN]: Timezone not set"));
    }

    [Fact]
    public void ParseLogLevel_ParseError()
    {
        Assert.Equal(LogLevel.Error, LogLines.ParseLogLevel("[ERR]: Disk full"));
    }

    [Fact]
    public void ParseLogLevel_ParseFatal()
    {
        Assert.Equal(LogLevel.Fatal, LogLines.ParseLogLevel("[FTL]: Not enough memory"));
    }

    [Fact]
    public void SupportUnknownLogLevel_ParseUnknown()
    {
        Assert.Equal(LogLevel.Unknown, LogLines.ParseLogLevel("[XYZ]: Gibberish message.. beep boop.."));
    }

    [Fact]
    public void ConvertLogLineToShortFormat_OutputForShortLogForTrace()
    {
        Assert.Equal("1:Line 13 - int myNum = 42;", LogLines.OutputForShortLog(LogLevel.Trace, "Line 13 - int myNum = 42;"));
    }

    [Fact]
    public void ConvertLogLineToShortFormat_OutputForShortLogForDebug()
    {
        Assert.Equal("2:The name 'LogLevel' does not exist in the current context", LogLines.OutputForShortLog(LogLevel.Debug, "The name 'LogLevel' does not exist in the current context"));
    }

    [Fact]
    public void ConvertLogLineToShortFormat_OutputForShortLogForInfo()
    {
        Assert.Equal("4:File moved", LogLines.OutputForShortLog(LogLevel.Info, "File moved"));
    }

    [Fact]
    public void ConvertLogLineToShortFormat_OutputForShortLogForWarning()
    {
        Assert.Equal("5:Unsafe password", LogLines.OutputForShortLog(LogLevel.Warning, "Unsafe password"));
    }

    [Fact]
    public void ConvertLogLineToShortFormat_OutputForShortLogForError()
    {
        Assert.Equal("6:Stack overflow", LogLines.OutputForShortLog(LogLevel.Error, "Stack overflow"));
    }

    [Fact]
    public void ConvertLogLineToShortFormat_OutputForShortLogForFatal()
    {
        Assert.Equal("42:Dumping all files", LogLines.OutputForShortLog(LogLevel.Fatal, "Dumping all files"));
    }

    [Fact]
    public void ConvertLogLineToShortFormat_OutputForShortLogForUnknown()
    {
        Assert.Equal("0:Something unknown happened", LogLines.OutputForShortLog(LogLevel.Unknown, "Something unknown happened"));
    }
}
