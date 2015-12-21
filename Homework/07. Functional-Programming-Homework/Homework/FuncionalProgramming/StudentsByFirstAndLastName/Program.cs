using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ClassStudent;

namespace StudentsByFirstAndLastName
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsDirectory database = new StudentsDirectory();
            var result = from student in database.Students
                         where student.FirstName[0] < student.LastName[0]
                         orderby student.FirstName
                         select student;
            foreach (var student in result)
            {
                Console.WriteLine("First Name: {0}, Last Name: {1}, Age: {2}, Faculty Number: {3}, Phone: {4}, Email: {5}, Marks: {6}", student.FirstName, student.LastName, student.Age, student.FacultyNumber, student.PhoneNumber,student.Email, string.Join(", ", student.Marks));
                Console.WriteLine();
            }
        }
    }
}
