namespace SchoolRegisterApp
{
    public abstract class StudentBase : NameObject
    {
        public StudentBase(string name) : base(name)
        {
        }
        public abstract void AddGrade(string grade);
    }
}