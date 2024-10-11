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
}

