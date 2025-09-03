namespace Password.Tests;

public class UnitTest1
{
    [Fact]
    public void ShouldReturnIneligableForNullString()
    {
        Assert.Equal("INELIGABLE", Password.CheckPassword(""));
    }

    [Fact]
    public void ShouldReturnWeakForOneCase()
    {
        Assert.Equal("WEAK", Password.CheckPassword("a"));
    }

    [Fact]
    public void ShouldReturnMediumForTwoCases()
    {
        Assert.Equal("MEDIUM", Password.CheckPassword("aA"));
    }

    [Fact]
    public void ShouldReturnMediumForThreeCases()
    {
        Assert.Equal("MEDIUM", Password.CheckPassword("aA1"));
    }

    [Fact]
    public void ShouldReturnStrongForFourCases()
    {
        Assert.Equal("STRONG", Password.CheckPassword("@aA1"));
    }

    [Fact]
    public void ShouldCountLengthGreaterThan8()
    {
        Assert.Equal("STRONG", Password.CheckPassword("@aAAAAAA"));
    }
}
