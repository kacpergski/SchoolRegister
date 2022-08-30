using SchoolRegisterApp;
namespace SchoolRegister.Test;


public class TypeTests
{
    [Fact]
    public void GetStudentRedturnsDiffrentObjects()
    {
     var student1 = GetStudent("Kacper");
     var student2 = GetStudent("Ewa");

     Assert.Equal("Kacper",student1.Name);
     Assert.Equal("Ewa",student2.Name);
    }
   
   // {
//arange
//act
//assert
  //  }
    private Student GetStudent(String name)
    {
        return new Student(name);
    }
}