using Xunit;
namespace ExercismCSharp.Tests;

public class BadgeTests
{
    [Fact]
    public void Badge_for_an_employee()
    {
        int? id = 734;
        string name = "Ernest Johnny Payne";
        string? department = "Strategic Communication";
        Assert.Equal("[734] - Ernest Johnny Payne - STRATEGIC COMMUNICATION", Badge.Print(id, name, department));
    }

    [Fact]
    public void Badge_for_a_new_employee()
    {
        int? id = null;
        string name = "Jane Johnson";
        string? department = "Procurement";
        Assert.Equal("Jane Johnson - PROCUREMENT", Badge.Print(id, name, department));
    }

    [Fact]
    public void Badge_for_the_owner()
    {
        int? id = 254;
        string name = "Charlotte Hale";
        string? department = null;
        Assert.Equal("[254] - Charlotte Hale - OWNER", Badge.Print(id, name, department));
    }

    [Fact]
    public void Badge_for_the_owner_with_id()
    {
        int? id = 254;
        string name = "Charlotte Hale";
        string? department = null;
        Assert.Equal("[254] - Charlotte Hale - OWNER", Badge.Print(id, name, department));
    }

    [Fact]
    public void Badge_for_the_owner_without_id()
    {
        int? id = null;
        string name = "Charlotte Hale";
        string? department = null;
        Assert.Equal("Charlotte Hale - OWNER", Badge.Print(id, name, department));
    }
}