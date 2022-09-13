using SchoolRegisterApp;
namespace SchoolRegister.Test;


public class StudentTests 
{
    [Fact]
    public void Test1()
    {
//arange
var student1 = new Student("Kacper");
student1.AddGrade("4");
student1.AddGrade("3");
student1.AddGrade("5");
student1.AddGrade("5");

// var a = 4;
// var b = 5;
// var excepted = 9;

//act

var result = student1.GetStatistic();

//var result = a + b;  

//assert
//var excepted = 4.0;
 //Assert.Equal(excepted,result);

Assert.Equal(4.3,result.average, 1);
Assert.Equal(5.5,result.maxGrade, 1);// 1  precision
Assert.Equal(3.0,result.minGrade, 1);


    }
}