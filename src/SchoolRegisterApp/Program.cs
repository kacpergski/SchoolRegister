using System;
using System.Collections.Generic;

//Napisz testy z lekcji dotyczące porównania referencji
// Twoje własnej klasy z użyciem Same, NotSame, Object.ReferenceEquals oraz extension method .Equals() 
//(np. employee.Equals(…);)


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
            

           // student.AddGrade(6.0);
           // student.AddGrade("4");
           // student.ChangeName(ref student, "Ewa");
            
           //var stat =  student.GetStatistic();
          //  student.ShowStatistic();
            //var grades = new [] {4.2, 5.0, 3.0};
           // var gradesList = new List<double>(){4.2, 5.0, 3.0};
           // double gradesSum = 0;
           // var average = 0.0;
           

           // average = gradesSum / gradesList.Count;
           // Console.WriteLine($"Sum of grades: {gradesSum:N2}");
           // Console.WriteLine($"Average grade: {average:N2}");
            //   foreach(var grade in gradesList)
          //  {
          //      gradesSum += grade;
          //      Console.WriteLine(grade);
                
         //   }

                 //zadanie domwe 11
        //var ageList =  new List<int>(){10,20,30,40};
       // var nameList = new List<string>(){"Kacper","Tomek","Marek","Pawel"};

     
          //  for (int i = 0; i < ageList.Count; i++)
          //  {
          //      Console.WriteLine($"{nameList[i]} {ageList[i]}"); 
          //  }

        

     
        }   
    }
}
