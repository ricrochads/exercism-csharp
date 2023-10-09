using Xunit;
namespace ExercismCSharp.Tests;

public class LanguagesTests
{
    [Fact]
    public void New_list()
    {
        Assert.Empty(Languages.NewList());
    }

    [Fact]
    public void Existing_list()
    {
        var expected = new List<string>();
        expected.Add("C#");
        expected.Add("Clojure");
        expected.Add("Elm");
        Assert.Equal(expected, Languages.GetExistingLanguages());
    }

    [Fact]
    public void Add_language()
    {
        var expected = new List<string>();
        expected.Add("C#");
        expected.Add("Clojure");
        expected.Add("Elm");
        expected.Add("Bash");
        var languages = new List<string>();
        languages.Add("C#");
        languages.Add("Clojure");
        languages.Add("Elm");
        Assert.Equal(expected, Languages.AddLanguage(languages, "Bash"));
    }

    [Fact]
    public void Count_languages()
    {
        var expected = new List<string>();
        expected.Add("C#");
        expected.Add("Clojure");
        expected.Add("Elm");
        Assert.Equal(3, Languages.CountLanguages(expected));
    }

    [Fact]
    public void Has_language_yes()
    {
        var expected = new List<string>();
        expected.Add("C#");
        expected.Add("Clojure");
        expected.Add("Elm");
        Assert.True(Languages.HasLanguage(expected, "Elm"));
    }

    [Fact]
    public void Has_language_no()
    {
        var expected = new List<string>();
        expected.Add("C#");
        expected.Add("Clojure");
        expected.Add("Elm");
        Assert.False(Languages.HasLanguage(expected, "D"));
    }

    [Fact]
    public void Reverse_list()
    {
        var expected = new List<string>();
        expected.Add("Elm");
        expected.Add("Clojure");
        expected.Add("C#");
        var languages = new List<string>();
        languages.Add("C#");
        languages.Add("Clojure");
        languages.Add("Elm");
        Assert.Equal(expected, Languages.ReverseList(languages));
    }

    [Fact]
    public void Is_exciting_yes()
    {
        var expected = new List<string>();
        expected.Add("C#");
        expected.Add("Clojure");
        expected.Add("Elm");
        Assert.True(Languages.IsExciting(expected));
    }

    [Fact]
    public void Is_exciting_too_many()
    {
        var languages = new List<string>();
        languages.Add("VBA");
        languages.Add("C#");
        languages.Add("Clojure");
        languages.Add("Elm");
        Assert.False(Languages.IsExciting(languages));
    }

    [Fact]
    public void Is_exciting_empty()
    {
        var languages = new List<string>();
        Assert.False(Languages.IsExciting(languages));
    }

    [Fact]
    public void Is_exciting_single_star()
    {
        var languages = new List<string>();
        languages.Add("C#");
        Assert.True(Languages.IsExciting(languages));
    }

    [Fact]
    public void Is_exciting_star_on_second_place_size_2()
    {
        var languages = new List<string>();
        languages.Add("F#");
        languages.Add("C#");
        Assert.True(Languages.IsExciting(languages));
    }

    [Fact]
    public void Is_exciting_star_on_second_place_size_3()
    {
        var languages = new List<string>();
        languages.Add("F#");
        languages.Add("C#");
        languages.Add("Clojure");
        Assert.True(Languages.IsExciting(languages));
    }

    [Fact]
    public void Remove_language_yes()
    {
        var expected = new List<string>();
        expected.Add("C#");
        expected.Add("Elm");
        var languages = new List<string>();
        languages.Add("C#");
        languages.Add("Clojure");
        languages.Add("Elm");
        Assert.Equal(expected, Languages.RemoveLanguage(languages, "Clojure"));
    }

    [Fact]
    public void Remove_language_no()
    {
        var expected = new List<string>();
        expected.Add("C#");
        expected.Add("Clojure");
        expected.Add("Elm");
        var languages = new List<string>();
        languages.Add("C#");
        languages.Add("Clojure");
        languages.Add("Elm");
        Assert.Equal(expected, Languages.RemoveLanguage(languages, "English"));
    }

    [Fact]
    public void Is_unique_yes()
    {
        var languages = new List<string>();
        languages.Add("C#");
        languages.Add("Clojure");
        languages.Add("Elm");
        Assert.True(Languages.IsUnique(languages));
    }

    [Fact]
    public void Is_unique_no()
    {
        var languages = new List<string>();
        languages.Add("C#");
        languages.Add("Clojure");
        languages.Add("Elm");
        languages.Add("C#");
        Assert.False(Languages.IsUnique(languages));
    }
}