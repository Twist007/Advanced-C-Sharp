//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ query syntax. 

using System;
using System.Linq;
using ClassStudentData;

class SortStudents
    {
        static void Main()
        {
        StudentsData data=new StudentsData();

            var sortStudentsLambda = data.Students.OrderByDescending(s => s.FirstName).ThenBy(a => a.LastName);

            Console.WriteLine("Whit Lambda expressions: ");
            foreach (var student in sortStudentsLambda)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            var sortStudentsLinq =
                from student in data.Students
                orderby student.FirstName descending, student.LastName 
                select student;

            Console.WriteLine( );
        Console.WriteLine("Whit LINQ: ");
        foreach (var student in sortStudentsLinq)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }
    }
    }

