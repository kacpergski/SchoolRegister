using System.Collections.Generic;

namespace SchoolRegisterApp
{
    public class Student
    { 
        private string name;  //pole prywatne do przechowywania imion
        private List<double> grades = new List<double>();
        public Student(string name)
        {
            this.name = name; // słowo this aby odwołać sie do klasy i przypisac name z konstruktora (to co w nawiasie) do pola name
        }

        public void AddGrade(double grade)
        {
        this.grades.Add(grade);
        }
    }
}