using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Canvas.models;
using Canvas.services;




namespace Canvas // Note: actual namespace depends on the project name.
{
    public class StudentHelper
    {
        private StudentServices studentServ = StudentServices.Current;
        public void addStudentToCourse(Course course, Person student)
        {
            course.Roster.Add(student);
        }

        public void removeStudentFromCourse(Course course, Person student)
        {
            course.Roster.Remove(student);
        }

        public void addStudent()
        {
            Console.WriteLine("Enter Student Firstname: ");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter Student Lastname: ");
            var lastName = Console.ReadLine();
            Console.WriteLine("Enter Student ID: ");
            var id = Console.ReadLine();
            Console.WriteLine("Enter Student Major: ");
            var cMajor = Console.ReadLine();
            var major = cMajor ?? string.Empty;

            Console.WriteLine("Enter Student Date of Birth: ");
            var dob = Console.ReadLine();
            var dateOfBirth = dob ?? string.Empty;



            Console.WriteLine("Enter Student classification: ");
            var classification = Console.ReadLine() ?? string.Empty;
            PersonClassification classEnum = PersonClassification.Freshman;
            if (classification.Equals("O", StringComparison.InvariantCultureIgnoreCase))
            {
                classEnum = PersonClassification.Sophmore;
            }
            else if (classification.Equals("J", StringComparison.InvariantCultureIgnoreCase))
            {
                classEnum = PersonClassification.Junior;
            }
            else if (classification.Equals("S", StringComparison.InvariantCultureIgnoreCase))
            {
                classEnum = PersonClassification.Senior;
            }
            else
            {
                classEnum = PersonClassification.Freshman;

            }

            Person students;
            var idz = int.Parse(id ?? "0");
            var DateOfBirthz = DateOnly.Parse(dob ?? "0");

            students = new Person { FirstName = firstName, LastName = lastName, ID = idz, major = cMajor, classification = classEnum, DateOfBirth = DateOfBirthz };
            StudentServices.Current.AddStudent(students);
            // ListStudents();
            studentServ.AddStudent(students);

        }
        public void ListStudents()
        {
            foreach (Person c in StudentServices.Current.StudentList)
            {
                Console.WriteLine(c);
            }

        }


        public void addCourse()
        {
            Console.WriteLine("Enter the name of the course work:");
            var courseName = Console.ReadLine();
        }



        public void UpdateStudent()
        {
            Console.WriteLine("Select the number of the student you wish to update:");
            ListStudents();
            var choice = Console.ReadLine();
            if (int.TryParse(choice, out int intChoice))
            {
                var studentToUpdate = StudentServices.Current.Get(intChoice);
                if (studentToUpdate != null)
                {
                    Console.WriteLine("Enter the new first name:");
                    studentToUpdate.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter the new last name:");
                    studentToUpdate.LastName = Console.ReadLine();
                    Console.WriteLine("Enter Student Major: ");
                    studentToUpdate.major = Console.ReadLine();
                    Console.WriteLine("Enter Student Date of Birth: ");
                    var date = Console.ReadLine();
                    studentToUpdate.DateOfBirth = DateOnly.Parse(date ?? "0");
                    Console.WriteLine("Enter Student classification: ");
                    var classification = Console.ReadLine() ?? string.Empty;
                    PersonClassification classEnum = PersonClassification.Freshman;
                    if (classification.Equals("O", StringComparison.InvariantCultureIgnoreCase))
                    {
                         classEnum = PersonClassification.Sophmore;
                    }
                    else if (classification.Equals("J", StringComparison.InvariantCultureIgnoreCase))
                    {
                        classEnum = PersonClassification.Junior;
                    }
                    else if (classification.Equals("S", StringComparison.InvariantCultureIgnoreCase))
                    {
                        classEnum = PersonClassification.Senior;
                    }
                    else
                    {
                        classEnum = PersonClassification.Freshman;

                    }
                    studentToUpdate.classification = classEnum;
                }
                else
                {
                    Console.WriteLine("Invalid student selection.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }


        public void DeleteStudent()
        {

            Console.WriteLine("Select the number of the student you wish to delete:");
            ListStudents();
            var choice = Console.ReadLine();
            if (int.TryParse(choice, out int intChoice))
            {
                var studentToDelete = StudentServices.Current.StudentList.ElementAtOrDefault(intChoice - 1);
                if (studentToDelete != null)
                {
                    studentServ.Delete(studentToDelete);

                    Console.WriteLine("Student deleted successfully.");

                }
                else
                {
                    Console.WriteLine("Invalid student selection.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

        }



    }



}














