using System;
using System.Collections.Generic;

namespace SchoolRegisterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var grades = new [] {4.2, 5.0, 3.0};
            var gradesList = new List<double>(){4.2, 5.0, 3.0};
            double gradesSum = 0;
            foreach(var grade in gradesList)
            {
                gradesSum += grade;
                Console.WriteLine(grade);
                
            }
            Console.WriteLine($"Sum of grades: {gradesSum}");
        }
    }
}
