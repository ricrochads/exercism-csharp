using Xunit;
namespace ExercismCSharp.Tests;

public class HelloWorldTests
{
    [Fact]
    public void SayHelloWorld()
    {
        Assert.Equal("Hello, World!", HelloWorld.Hello());
    }  
}