//Print all students that have at least one mark Excellent (6). Using LINQ first select them into a new anonymous class that holds { FullName + Marks}.

using System;
using System.Linq;
using ClassStudentData;

class ExcellentStudents
{
    static void Main()
    {
        var data = new StudentsData();

        var ExcellentStudents =
            from student in data.Students
            where student.Marks.Contains(6)
            select new
            {
                FullName = string.Join(" ", student.FirstName, student.LastName),
                Marks = string.Join(", ", student.Marks)
            };

        foreach (var student in ExcellentStudents)
        {
            Console.WriteLine("{0} {1}", student.FullName, student.Marks);
        }

    }
}

