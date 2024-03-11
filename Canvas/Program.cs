using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Canvas.models;
using Canvas.services;




namespace Canvas // Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {   
           var ListOfStudents = StudentServices.Current;
           var ListOfCourses = CourseServices.Current;
          
            
             bool cont = true;
             var studentHelp = new StudentHelper();
              while(cont)
             {
                Console.WriteLine("Welcome to Canvas");
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Add a new student");
                Console.WriteLine("2. List all students");
                Console.WriteLine("3. Search for a student");
                Console.WriteLine("4. Update Student");
                Console.WriteLine("5. Delete Student");
                Console.WriteLine("6. Exit");
                
                var input = Console.ReadLine();
                if(int.TryParse(input, out var result))
                {
                if(result == 1)
                {
                    studentHelp.addStudent();
                }
                else if(result == 2)
                {
                    studentHelp.ListStudents();
                }
                else if(result == 3)
                {
                    Console.WriteLine("Search for a student's name:");
                    var searchTerm = Console.ReadLine();
                    var searchResults = StudentServices.Current.Search(searchTerm);
                    foreach (var student in searchResults)
                    {
                        Console.WriteLine(student);
                    }

                }
                else if(result == 4)
                {
                    studentHelp.UpdateStudent();
                }
                else if(result == 5)
                {
                    studentHelp.DeleteStudent();
                }
                else if(result == 6)
                {
                    cont = false;
                }

                } 
                

            }

            foreach(Person c in StudentServices.Current.Students){

            }
           
          }


       
    



    }
}