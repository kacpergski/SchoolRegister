namespace SchoolRegister.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
//arange
var a = 4;
var b = 5;
var excepted = 9;

//act
var result = a + b;  

//assert
 Assert.Equal(excepted,result);

    }
}