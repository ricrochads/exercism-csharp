using Xunit;
namespace ExercismCSharp.Tests;

public class IdentifierTests
{
    [Fact]
    public void Clean_single_letter()
    {
        Assert.Equal("A", Identifier.Clean("A"));
    }

    [Fact]
    public void Clean_clean_string()
    {
        Assert.Equal("àḃç", Identifier.Clean("àḃç"));
    }

    [Fact]
    public void Clean_string_with_spaces()
    {
        Assert.Equal("my___Id", Identifier.Clean("my   Id"));
    }

    [Fact]
    public void Clean_string_with_control_char()
    {
        Assert.Equal("myCTRLId", Identifier.Clean("my\0Id"));
    }

    [Fact]
    public void Clean_empty_string()
    {
        Assert.Equal(string.Empty, Identifier.Clean(string.Empty));
    }

    [Fact]
    public void Convert_kebab_to_camel_case()
    {
        Assert.Equal("àḂç", Identifier.Clean("à-ḃç"));
    }

    [Fact]
    public void Clean_string_with_numbers()
    {
        Assert.Equal("MyFinder", Identifier.Clean("1My2Finder3"));
    }
    
    [Fact]
    public void Omit_lower_case_greek_letters()
    {
        Assert.Equal("MyΟFinder", Identifier.Clean("MyΟβιεγτFinder"));
    }
}