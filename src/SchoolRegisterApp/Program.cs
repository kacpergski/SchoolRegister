using System;
using System.Collections.Generic;

namespace SchoolRegisterApp
//dzień 5
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Kacper");
            student.AddGrade(5.0);

            //var grades = new [] {4.2, 5.0, 3.0};
            var gradesList = new List<double>(){4.2, 5.0, 3.0};
            double gradesSum = 0;
            var average = 0.0;
            foreach(var grade in gradesList)
            {
                gradesSum += grade;
                Console.WriteLine(grade);
                
            }

            average = gradesSum / gradesList.Count;
            Console.WriteLine($"Sum of grades: {gradesSum:N2}");
            Console.WriteLine($"Average: {average:N2}");
        }
    }
}
