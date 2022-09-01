using System;
using System.Collections.Generic;

namespace SchoolRegisterApp
{
    public class Student
    { 
        //private string name;  //pole prywatne do przechowywania imion
        private List<double> gradesList = new List<double>(){};
        

        public Student(string name)
        {
            this.Name = name; // słowo this aby odwołać sie do klasy i przypisac name z konstruktora (to co w nawiasie) do pola name
        }

        // public string Name
        // {
        //     get
        //     {
        //         return this.name;
        //     }
        // }
        public string Name { get; set; }
              
        public void AddGrade(double grade)
        {
           
            if (grade >= 1.0 && grade <= 6.0)
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
             switch(Sgrade)
                 {
                      case "1+":
                      student.AddGrade(1.5);
                      break;
                      case "2+":
                      student.AddGrade(2.5);
                      break;
                      case "3+":
                      student.AddGrade(3.5);
                      break;
                      case "4+":
                      student.AddGrade(4.5);
                      break;
                      case "5+":
                      student.AddGrade(5.5);
                      break;
                      case "2-":
                      student.AddGrade(1.75);
                      break;
                      case "3-":
                      student.AddGrade(2.75);
                      break;
                      case "4-":
                      student.AddGrade(3.75);
                      break;
                      case "5-":
                      student.AddGrade(4.75);
                      break;
                      case "6-":
                      student.AddGrade(5.75);
                      break;

                      default:
                       var grade = double.Parse(Sgrade);
                      this.gradesList.Add(Sgrade);
                      //case "q":
                      
                      break;



            int result;
            int.TryParse(Sgrade, out result);
            
        }

        public void ChangeName(ref Student student, string name)
        {
        
          foreach (var ch in name)
          {
             if (char.IsDigit(ch) == false)
             {
                continue;
             }
             else
             {
                Console.WriteLine("Digit in name");
             }      
           }

         student.Name = name;
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

           
        }

        

        }

}