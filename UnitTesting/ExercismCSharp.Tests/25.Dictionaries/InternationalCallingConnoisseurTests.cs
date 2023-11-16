using Xunit;
namespace ExercismCSharp.Tests;

public class DialingCodesTests
{
    [Fact]
    public void CreateNewDictionary_EmptyDictionaryIsEmpty()
    {
        var emptyDict = DialingCodes.GetEmptyDictionary();
        Assert.Empty(emptyDict);
    }

    [Fact]
    public void CreatePrePopulatedDictionary_ExistingDictionaryCountIs3()
    {
        var prePopulated = DialingCodes.GetExistingDictionary();
        Assert.Equal(3, prePopulated.Count);
    }

    [Fact]
    public void CreatePrePopulatedDictionary_ExistingDictionary1IsUnitedStatesOfAmerica()
    {
        var prePopulated = DialingCodes.GetExistingDictionary();
        Assert.Equal("United States of America", prePopulated[1]);
    }

    [Fact]
    public void CreatePrePopulatedDictionary_ExistingDictionary55IsBrazil()
    {
        var prePopulated = DialingCodes.GetExistingDictionary();
        Assert.Equal("Brazil", prePopulated[55]);
    }

    [Fact]
    public void CreatePrePopulatedDictionary_ExistingDictionary91IsIndia()
    {
        var prePopulated = DialingCodes.GetExistingDictionary();
        Assert.Equal("India", prePopulated[91]);
    }

    [Fact]
    public void AddCountryToEmptyDictionary_Single()
    {
        var countryCodes = DialingCodes.AddCountryToEmptyDictionary(44, "United Kingdom");
        Assert.Single(countryCodes);
    }

    [Fact]
    public void AddCountryToEmptyDictionary_44IsUnitedKingdom()
    {
        var countryCodes = DialingCodes.AddCountryToEmptyDictionary(44, "United Kingdom");
        Assert.Equal("United Kingdom", countryCodes[44]);
    }

    [Fact]
    public void AddCountryToExistingDictionary_CountIs1()
    {
        var countryCodes = DialingCodes.AddCountryToExistingDictionary(DialingCodes.GetExistingDictionary(), 44, "United Kingdom");
        Assert.Equal(4, countryCodes.Count);
    }

    [Fact]
    public void AddCountryToExistingDictionary_1IsUnitedStatesOfAmerica()
    {
        var countryCodes = DialingCodes.AddCountryToExistingDictionary(DialingCodes.GetExistingDictionary(), 44, "United Kingdom");
        Assert.Equal("United States of America", countryCodes[1]);
    }

    [Fact]
    public void AddCountryToExistingDictionary_44IsUnitedKingdom()
    {
        var countryCodes = DialingCodes.AddCountryToExistingDictionary(DialingCodes.GetExistingDictionary(), 44, "United Kingdom");
        Assert.Equal("United Kingdom", countryCodes[44]);
    }

    [Fact]
    public void AddCountryToExistingDictionary_55IsBrazil()
    {
        var countryCodes = DialingCodes.AddCountryToExistingDictionary(DialingCodes.GetExistingDictionary(), 44, "United Kingdom");
        Assert.Equal("Brazil", countryCodes[55]);
    }

    [Fact]
    public void AddCountryToExistingDictionary_91IsIndia()
    {
        var countryCodes = DialingCodes.AddCountryToExistingDictionary(DialingCodes.GetExistingDictionary(), 44, "United Kingdom");
        Assert.Equal("India", countryCodes[91]);
    }

    [Fact]
    public void GetCountryNameByDialingCode_Success()
    {
        var countryName = DialingCodes.GetCountryNameFromDictionary(DialingCodes.GetExistingDictionary(), 55);
        Assert.Equal("Brazil", countryName);
    }

    [Fact]
    public void GetCountryNameForNonExistentDialingCode_ReturnsEmptyString()
    {
        var countryName = DialingCodes.GetCountryNameFromDictionary(DialingCodes.GetExistingDictionary(), 999);
        Assert.Equal(string.Empty, countryName);
    }

    [Fact]
    public void CheckCountryExistsInDictionary_CountryExists()
    {
        var exists = DialingCodes.CheckCodeExists(DialingCodes.GetExistingDictionary(), 55);
        Assert.True(exists);
    }

    [Fact]
    public void CheckCountryExistsInDictionary_NonExistentCountry()
    {
        var exists = DialingCodes.CheckCodeExists(DialingCodes.GetExistingDictionary(), 999);
        Assert.False(exists);
    }

    [Fact]
    public void UpdateCountryNameInDictionary_CountIs3()
    {
        var countryCodes = DialingCodes.UpdateDictionary(DialingCodes.GetExistingDictionary(), 1, "les États-Unis");
        Assert.Equal(3, countryCodes.Count);
    }

    [Fact]
    public void UpdateCountryNameInDictionary_1IsLesEtatsUnis()
    {
        var countryCodes = DialingCodes.UpdateDictionary(DialingCodes.GetExistingDictionary(), 1, "les États-Unis");
        Assert.Equal("les États-Unis", countryCodes[1]);
    }

    [Fact]
    public void UpdateCountryNameInDictionary_55IsBrazil()
    {
        var countryCodes = DialingCodes.UpdateDictionary(DialingCodes.GetExistingDictionary(), 1, "les États-Unis");
        Assert.Equal("Brazil", countryCodes[55]);
    }

    [Fact]
    public void UpdateCountryNameInDictionary_91IsIndia()
    {
        var countryCodes = DialingCodes.UpdateDictionary(DialingCodes.GetExistingDictionary(), 1, "les États-Unis");
        Assert.Equal("India", countryCodes[91]);
    }

    [Fact]
    public void UpdateCountryNameInDictionary_NonExistentCountry_CountIs3()
    {
        var countryCodes = DialingCodes.UpdateDictionary(DialingCodes.GetExistingDictionary(), 999, "Newlands");
        Assert.Equal(3, countryCodes.Count);
    }

    [Fact]
    public void UpdateCountryNameInDictionary_NonExistentCountry_1IsUnitedStatesOfAmerica()
    {
        var countryCodes = DialingCodes.UpdateDictionary(DialingCodes.GetExistingDictionary(), 999, "Newlands");
        Assert.Equal("United States of America", countryCodes[1]);
    }

    [Fact]
    public void UpdateCountryNameInDictionary_NonExistentCountry_55IsBrazil()
    {
        var countryCodes = DialingCodes.UpdateDictionary(DialingCodes.GetExistingDictionary(), 999, "Newlands");
        Assert.Equal("Brazil", countryCodes[55]);
    }

    [Fact]
    public void UpdateCountryNameInDictionary_NonExistentCountry_91IsIndia()
    {
        var countryCodes = DialingCodes.UpdateDictionary(DialingCodes.GetExistingDictionary(), 999, "Newlands");
        Assert.Equal("India", countryCodes[91]);
    }

    [Fact]
    public void RemoveCountryFromDictionary_CountIs2()
    {
        var countryCodes = DialingCodes.RemoveCountryFromDictionary(DialingCodes.GetExistingDictionary(), 91);
        Assert.Equal(2, countryCodes.Count);
    }

    [Fact]
    public void RemoveCountryFromDictionary_1IsUnitedStatesOfAmerica()
    {
        var countryCodes = DialingCodes.RemoveCountryFromDictionary(DialingCodes.GetExistingDictionary(), 91);
        Assert.Equal("United States of America", countryCodes[1]);
    }

    [Fact]
    public void RemoveCountryFromDictionary_55IsBrazil()
    {
        var countryCodes = DialingCodes.RemoveCountryFromDictionary(DialingCodes.GetExistingDictionary(), 91);
        Assert.Equal("Brazil", countryCodes[55]);
    }

    [Fact]
    public void RemoveCountryFromDictionary_NonExistentCountry_CountIs3()
    {
        var countryCodes = DialingCodes.RemoveCountryFromDictionary(DialingCodes.GetExistingDictionary(), 999);
        Assert.Equal(3, countryCodes.Count);
    }

    [Fact]
    public void RemoveCountryFromDictionary_NonExistentCountry_1IsUnitedStatesOfAmerica()
    {
        var countryCodes = DialingCodes.RemoveCountryFromDictionary(DialingCodes.GetExistingDictionary(), 999);
        Assert.Equal("United States of America", countryCodes[1]);
    }

    [Fact]
    public void RemoveCountryFromDictionary_NonExistentCountry_55IsBrazil()
    {
        var countryCodes = DialingCodes.RemoveCountryFromDictionary(DialingCodes.GetExistingDictionary(), 999);
        Assert.Equal("Brazil", countryCodes[55]);
    }

    [Fact]
    public void RemoveCountryFromDictionary_NonExistentCountry_91IsIndia()
    {
        var countryCodes = DialingCodes.RemoveCountryFromDictionary(DialingCodes.GetExistingDictionary(), 999);
        Assert.Equal("India", countryCodes[91]);
    }

    [Fact]
    public void FindLongestCountryNameInDictionary_Success()
    {
        var countryCodes = DialingCodes.AddCountryToExistingDictionary(DialingCodes.GetExistingDictionary(), 263, "Zimbabwe");
        var longestCountryName = DialingCodes.FindLongestCountryName(countryCodes);
        Assert.Equal("United States of America", longestCountryName);
    }

    [Fact]
    public void FindLongestCountryNameInEmptyDictionary_ReturnsEmptyString()
    {
        var longestCountryName = DialingCodes.FindLongestCountryName(DialingCodes.GetEmptyDictionary());
        Assert.Equal(string.Empty, longestCountryName);
    }
}