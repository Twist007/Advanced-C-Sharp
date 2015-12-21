using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassStudent;

namespace SortStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsDirectory database = new StudentsDirectory();
            var result = database.Students.OrderByDescending(w => w.FirstName).ThenByDescending(s => s.LastName);
            foreach (var student in result)
            {
                Console.WriteLine("First Name: {0}, Last Name: {1}, Age: {2}, Faculty Number: {3}, Phone: {4}, Email: {5}, Marks: {6}", student.FirstName, student.LastName, student.Age, student.FacultyNumber, student.PhoneNumber,student.Email, string.Join(", ", student.Marks));
                Console.WriteLine();
            }
        }
    }
}
