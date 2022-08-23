namespace SchoolRegisterApp
{
    public class Student
    { 
        private string name;  //pole prywatne do przechowywania imion
        public Student(string name)
        {
            this.name = name; // słowo this aby odwołać sie do klasy i przypisac name z konstruktora (to co w nawiasie) do pola name
        }
    }
}