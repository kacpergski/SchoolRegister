namespace SchoolRegisterApp
{
    internal class Student
    { 
        private string name;  //pole prywatne do przechowywania imion
        public Student(string name)
        {
            this.name = name; // słowo this aby przypisac name z konstruktora (to co w nawiasie) do pola name
        }
    }
}