using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassStudent;

namespace WeakStudens
{
    class Program
    {
        static void Main()
        {
            StudentsDirectory database = new StudentsDirectory();
            var result = from student in database.Students
                         where student.Marks.Contains(2)
                         select new { FullName = string.Join(" ", student.FirstName, student.LastName), Marks = string.Join(" ", student.Marks) };
            int count;
            foreach (var student in result)
            {
                count = 0;
                foreach (var mark in student.Marks)
                {
                    if (mark == '2')
                        count++;
                }
                if (count == 2)
                    Console.WriteLine("Name: {0}, Marks: {1}", student.FullName, student.Marks);
            }
        }
    }
}
