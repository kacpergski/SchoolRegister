using SchoolRegisterApp;
namespace SchoolRegister.Test;


public class TypeTests
{
    [Fact]
    public void GetStudentRedturnsDiffrentObjects()
    {
     var student1 = GetStudent("Kacper");
     var student2 = GetStudent("Ewa");
     
     //Assert.Equal("Kacper",student1.Name);
     //Assert.Equal("Ewa",student2.Name);
    
     Assert.NotSame(student1,student2);
     Assert.False(Object.ReferenceEquals(student1,student2));
    }
    [Fact]
    public void TwoVarsCanReferenceEquals()
    {
    var student1 = GetStudent("Kacper");
    var student2 = student1;
    //Assert.NotSame(student1,student2);
    Assert.Same(student1,student2);
    Assert.True(Object.ReferenceEquals(student1,student2));

    }
    [Fact]
    public void CanSetNameFromReference()
    {
    var student1 = GetStudent("Kacper");
    this.SetName(student1, "newName");
    Assert.Equal("newName", student1.Name);
    //Assert.Same(student1,student2);
    //Assert.True(Object.ReferenceEquals(student1,student2));

    }
   // {
//arange
//act
//assert
  //  }
    private Student GetStudent(string name)
    {
        return new Student(name);
    }
    private void SetName(Student student, string name)
    {
    student.Name = name;
    }
}