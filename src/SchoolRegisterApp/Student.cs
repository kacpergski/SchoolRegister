using System;
using System.Collections.Generic;

namespace SchoolRegisterApp
{
    public class Student

    { 
      public delegate void GradeAddedDelegate(object sender, EventArgs args);
      public event GradeAddedDelegate GradeAdded;
        private string name;  //pole prywatne do przechowywania imion
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
              
        // public void AddGrade(double grade)
        // {
           
        //     if (grade >= 1.0 && grade <= 6.0)
        //     {
              
        //     this.gradesList.Add(grade);
              
        //     }
        // else
        //     {
        //        Console.WriteLine("Wrong grade"); 
        //     }
        // }        
         public void AddGrade(string grade)
        {      
         // if (GradeAdded != null && grade <=3)
         // {
         //    GradeAdded(this, new EventArgs());
         // }
             
            
             switch(grade)
                 {
                      case "1+":
                        if (GradeAdded != null )
                        {
                          GradeAdded(this, new EventArgs());
                        }
                      this.gradesList.Add(1.5);
                      break;
                      case "2+":
                       if (GradeAdded != null )
                        {
                          GradeAdded(this, new EventArgs());
                        }
                      this.gradesList.Add(2.5);
                      break;
                      case "3+":
                      this.gradesList.Add(3.5);
                      break;
                      case "4+":
                      this.gradesList.Add(4.5);
                      break;
                      case "5+":
                      this.gradesList.Add(5.5);
                      break;
                      case "2-":
                       if (GradeAdded != null )
                        {
                          GradeAdded(this, new EventArgs());
                        }
                      this.gradesList.Add(1.75);
                      break;
                      case "3-":
                       if (GradeAdded != null )
                        {
                          GradeAdded(this, new EventArgs());
                        }
                      this.gradesList.Add(2.75);
                      break;
                      case "4-":
                      this.gradesList.Add(3.75);
                      break;
                      case "5-":
                      this.gradesList.Add(4.75);
                      break;
                      case "6-":
                      this.gradesList.Add(5.75);
                      break; // dodac return wartość i dopiero ten return dodawac do gradelist wtedy mozna skrócic i dodawac nowe funkcje

                      default:
                     try{
                      var Sgrade = double.Parse(grade);
                      if (Sgrade <= 9 && Sgrade >= 1)
                      {
                        if (GradeAdded != null && Sgrade <=3)
                                 {
                                    GradeAdded(this, new EventArgs());
                                 }

                      this.gradesList.Add(Sgrade); 
                         }
                      else
                        {
                        throw new ArgumentException($"Invalid argument: {nameof(grade)}");
                        }
                     }
                     catch(ArgumentException ex)
                     {
                        Console.WriteLine($"Argument{ex.Message}");
                     }
                     catch(FormatException ex)
                     {
                        Console.WriteLine(ex.Message);
                     }
                      break;   

                     }
                        
       
          
        
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