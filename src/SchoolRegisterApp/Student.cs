using System;
using System.Collections.Generic;

namespace SchoolRegisterApp
{
    public class Student
    { 
        private string name;  //pole prywatne do przechowywania imion
        private List<double> gradesList = new List<double>(){4.2, 5.0, 3.0};

        public Student(string name)
        {
            this.name = name; // słowo this aby odwołać sie do klasy i przypisac name z konstruktora (to co w nawiasie) do pola name
        }

        public void AddGrade(double grade)
        {
        this.gradesList.Add(grade);
        }

        public Statistic GetStatistic()
        { 
            var studentStatistic = new Statistic();

            studentStatistic.minGrade = double.MaxValue;
            studentStatistic.maxGrade = double.MinValue;

            foreach (var grade in gradesList)
            {
                studentStatistic.minGrade = Math.Min(studentStatistic.minGrade, grade);
                studentStatistic.maxGrade = Math.Max(studentStatistic.maxGrade, grade);
            }

            return studentStatistic;

            //Console.WriteLine($"Minimal garde: {studentStatistic.minGrade:N2}");
            //Console.WriteLine($"Maximal grade: {maxGrade:N2}");
        }

        

        }

}