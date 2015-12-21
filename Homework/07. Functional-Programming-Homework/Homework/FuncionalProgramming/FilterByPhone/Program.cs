using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassStudent;

namespace FilterByPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsDirectory database = new StudentsDirectory();
            var result = from student in database.Students
                         where student.PhoneNumber.Contains("02") || student.PhoneNumber.Contains("+3592") || student.PhoneNumber.Contains("+359 2")
                         select student;
            foreach (var student in result)
            {
                Console.WriteLine("First Name: {0}, Last Name: {1}, Age: {2}, Faculty Number: {3}, Phone: {4}, Email: {5}, Marks: {5}", student.FirstName, student.LastName, student.Age, student.FacultyNumber, student.PhoneNumber, student.Email, string.Join(", ", student.Marks));
                Console.WriteLine();
            }
        }
    }
}
