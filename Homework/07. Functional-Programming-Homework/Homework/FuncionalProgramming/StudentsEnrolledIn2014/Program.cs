using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassStudent;

namespace StudentsEnrolledIn2014
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsDirectory database = new StudentsDirectory();
            var result = from student in database.Students
                         where student.FacultyNumber[4] == '1' && student.FacultyNumber[5] == '4'
                         select student;
            foreach (var student in result)
            {
                Console.WriteLine("First Name: {0}, Last Name: {1}, Age: {2}, Faculty Number: {3}, Phone: {4}, Email: {5}, Marks: {5}", student.FirstName, student.LastName, student.Age, student.FacultyNumber, student.PhoneNumber, student.Email, string.Join(", ", student.Marks));
                Console.WriteLine();
            }
        }
    }
}
