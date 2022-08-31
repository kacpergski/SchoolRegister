using System;
using System.Collections.Generic;

namespace SchoolRegisterApp
{
    public class Student
    { 
        private string name;  //pole prywatne do przechowywania imion
        private List<double> gradesList = new List<double>(){};

        public Student(string name)
        {
            this.name = name; // słowo this aby odwołać sie do klasy i przypisac name z konstruktora (to co w nawiasie) do pola name
        }

        // public string Name
        // {
        //     get
        //     {
        //         return this.name;
        //     }
        // }
        public String Name { get; set; }
              
        public void AddGrade(double grade)
        {
           
            if (grade >= 2.0 && grade <= 6.0)
            {
              
            this.gradesList.Add(grade);
              
            }
        else
            {
               Console.WriteLine("Wrong grade"); 
            }
        }        
         public void AddGrade(string Sgrade)
        {
            int result;
            int.TryParse(Sgrade, out result);
            this.gradesList.Add(result);
        }

          
              
            
      
        
    
    
      

        public Statistic GetStatistic()
        { 
            double gradeSum = 0;
            var studentStatistic = new Statistic();

            studentStatistic.minGrade = double.MaxValue;
            studentStatistic.maxGrade = double.MinValue;

            foreach (var grade in gradesList)
            {
                
                gradeSum += grade;

                studentStatistic.minGrade = Math.Min(studentStatistic.minGrade, grade);
                studentStatistic.maxGrade = Math.Max(studentStatistic.maxGrade, grade);

                
            }

                studentStatistic.average = (gradeSum/gradesList.Count);

            return studentStatistic;

            //Console.WriteLine($"Minimal garde: {studentStatistic.minGrade:N2}");
            //Console.WriteLine($"Maximal grade: {maxGrade:N2}");
        }

        

        }

}