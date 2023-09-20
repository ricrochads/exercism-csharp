using Xunit;
namespace ExercismCSharp.Tests;

public class PhoneNumberTests
{
    [Fact]
    public void Analyze()
    {
        var phoneNumber = "631-555-1234";
        Assert.Equal((false, true, "1234"), PhoneNumber.Analyze(phoneNumber));
    }

    [Fact]
    public void IsFake()
    {
        var phoneNumber = "555-212-1234";
        Assert.False(PhoneNumber.IsFake(PhoneNumber.Analyze(phoneNumber)));

        phoneNumber = "212-555-1234";
        Assert.True(PhoneNumber.IsFake(PhoneNumber.Analyze(phoneNumber)));
    }
}