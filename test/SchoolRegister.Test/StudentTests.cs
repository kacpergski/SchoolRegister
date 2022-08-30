using SchoolRegisterApp;
namespace SchoolRegister.Test;


public class UnitTest1
{
    [Fact]
    public void Test1()
    {
//arange
var student1 = new Student("Kacper");
student1.AddGrade(4.0);
student1.AddGrade(3.0);
student1.AddGrade(5.0);

// var a = 4;
// var b = 5;
// var excepted = 9;

//act

var result = student1.GetStatistic();

//var result = a + b;  

//assert
//var excepted = 4.0;
 //Assert.Equal(excepted,result);

Assert.Equal(4.0,result.average);
Assert.Equal(5.0,result.maxGrade);
Assert.Equal(3.0,result.minGrade);


    }
}