using System;
using System.Collections.Generic;

namespace SchoolRegisterApp
//dzień 5
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Kacper");
            student.GradeAdded += OnGradeadded;
            while (true)
            {
                 Console.WriteLine($"Input 9 for exit");
                 Console.WriteLine($"Hello enter grade for {student.Name}");
                              
                string input = Console.ReadLine();
                 if (input == "q")
                 {
                    break;
                 }
                  student.AddGrade(input);           
              
            }   
            static void OnGradeadded(object sender, EventArgs args)
            {
              Console.WriteLine("Oh no! We should inform student’s parents about this fact");
            }

               var stat = student.GetStatistic();
               Console.WriteLine($"Minimal garde: {stat.minGrade:N2}");
               Console.WriteLine($"Maximal grade: {stat.maxGrade:N2}");
               Console.WriteLine($"Average grade: {stat.average:N2}");
           
       
        }   
    }
}
