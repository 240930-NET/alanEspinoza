namespace lorcanaDeckTracker.Tests;

public class UnitTest1
{
    //check for true 
    [Fact]
    public void ColorIsValidUnitTest0()
    {
        //arrange
        string colorCheck = "AMBER";
        //act
        bool check = Validate.ColorIsValid(colorCheck);
        //assert
        Assert.True(check);
    }

    //check for false
    [Fact]
    public void ColorIsValidUnitTest1()
    {
        //arrange
        string colorCheck = "yellow";
        //act
        bool check = Validate.ColorIsValid(colorCheck);
        //assert
        Assert.False(check);
    }

    //Check for true
    [Theory]
    [InlineData("true",true)]
    [InlineData("TRUE",true)]
    [InlineData("false",true)]
    [InlineData("False",true)]
    [InlineData("falSE",true)]
    [InlineData("tRuE",true)]
    [InlineData("true ",true)]
    public void OptionIsTrueOrFalseUnitTest2(string boolcheck, bool expected)
    {
        //arrange
        //string boolcheck= "true";
        //act
        bool check = Validate.OptionIsTrueOrFalse(boolcheck);
        //assert
        Assert.Equal(check, expected);

    }

    //Check for false
    [Theory]
    [InlineData("tr",false)]
    [InlineData("tru",false)]
    [InlineData("fal",false)]
    [InlineData("12312341432",false)]
    [InlineData("adfafa",false)]
    public void OptionIsTrueOrFalseUnitTest3(string boolcheck, bool expected)
    {
        //arrange
        //string boolcheck= "true";
        //act
        bool check = Validate.OptionIsTrueOrFalse(boolcheck);
        //assert
        Assert.Equal(check, expected);

    }

    //check for true
    [Theory]
    [InlineData("CHARACTER", true)]
    [InlineData("actIon", true)]
    [InlineData("locaTION", true)]
    [InlineData("item", true)]
    [InlineData("character", true)]
    [InlineData("    ITEM    ", true)]
    public void CardTypeIsValidUnitTest4(string typecheck, bool expected)
    {
        //arrange

        //act 
        bool check = Validate.CardTypeIsValid(typecheck);
        //
        //assert
        Assert.Equal(check, expected);

    }

    //check for false
    [Theory]
    [InlineData("CHARACTE", false)]
    [InlineData("actIo", false)]
    [InlineData("lfasdfa", false)]
    [InlineData("42356234253456", false)]
    [InlineData("afafafsf", false)]
    public void CardTypeIsValidUnitTest5(string typecheck, bool expected)
    {
        //arrange

        //act 
        bool check = Validate.CardTypeIsValid(typecheck);
        //
        //assert
        Assert.Equal(check, expected);

    }
}

