using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassStudent;

namespace ExcellentStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsDirectory database = new StudentsDirectory();
            var result = from student in database.Students
                         where student.Marks.Contains(6)
                         select new {FullName=string.Join(" ",student.FirstName,student.LastName), Marks=string.Join(" ",student.Marks) };
            foreach (var student in result)
            {
                Console.WriteLine("Name: {0} - Grades: {1}", student.FullName, student.Marks);
            }
        }
    }
}
