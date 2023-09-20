namespace ExercismCSharp;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] numberComponents = phoneNumber.Split('-');
        bool isNewYorkAreaCode = numberComponents[0] == "212";
        bool isFakePrefixCode = numberComponents[1] == "555";
        string localNumber = numberComponents[2];
        return (isNewYorkAreaCode, isFakePrefixCode, localNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}