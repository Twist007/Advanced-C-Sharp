using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassStudent;

namespace StudentsByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsDirectory database = new StudentsDirectory();
            var result = from student in database.Students
                         where student.Age > 18 && student.Age < 24
                         select new { student.FirstName, student.LastName, student.Age };
            foreach (var student in result)
            {
                Console.WriteLine("First Name: {0}, Last Name: {1}, Age: {2}",student.FirstName,student.LastName,student.Age);
            }
        }
    }
}
