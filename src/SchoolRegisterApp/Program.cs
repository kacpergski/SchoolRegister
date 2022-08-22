using System;

namespace SchoolRegisterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new [] {4.2, 5.0, 3.0};
            double gradesSum = 0;
            foreach(var grade in grades)
            {
                gradesSum += grade;
                Console.WriteLine(grade);
                Console.WriteLine();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
