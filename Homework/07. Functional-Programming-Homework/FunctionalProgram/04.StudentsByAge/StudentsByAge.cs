//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24. The query should return only the first name, last name and age.

using System;
using System.Linq;
using System.Linq.Expressions;
using ClassStudentData;

class StudentsByAge
{
    static void Main()
    {
        StudentsData data = new StudentsData();

        var studentsbyAge =
            from student in data.Students
            where student.Age > 17 && student.Age < 25
            select new {student.FirstName, student.LastName, student.Age};

        foreach (var student in studentsbyAge)
        {
            Console.WriteLine("{0} {1} - {2}", student.FirstName,student.LastName, student.Age);
        }

    }
}

