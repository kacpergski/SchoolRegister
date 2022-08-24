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
            double minGrade = double.MaxValue;
            double maxGrade = double.MinValue;


            foreach (var grade in gradesList)
            {
                minGrade = Math.Min(minGrade, grade);
                maxGrade = Math.Max(maxGrade, grade);
            }

            foreach(var grade in gradesList)
            {
                gradesSum += grade;
                Console.WriteLine(grade);
                
            }

            average = gradesSum / gradesList.Count;
            Console.WriteLine($"Sum of grades: {gradesSum:N2}");
            Console.WriteLine($"Average grade: {average:N2}");
            Console.WriteLine($"Minimal garde: {minGrade:N2}");
            Console.WriteLine($"Maximal grade: {maxGrade:N2}");
        }
    }
}
