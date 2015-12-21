//Print all students with phones in Sofia (starting with 02 / +3592 / +359 2). Use LINQ.

using System;
using ClassStudentData;
using System.Linq;
class StudentsByPhone
{
    static void Main()
    {
        var data = new StudentsData();

        var filterStudentsByEmailDomain =
            from student in data.Students
            where
                (student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") ||
                 student.Phone.StartsWith("+359 2"))
            select student;

        foreach (var student in filterStudentsByEmailDomain)
        {
            Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Phone);
        }

    }
}

