//Print all students that have email @abv.bg. Use LINQ.
using System;
using System.Linq;
using ClassStudentData;

class FilterStudentsByEmailDomain
{
    static void Main()
    {
        StudentsData data = new StudentsData();

        var filterStudentsByEmailDomain =
            from student in data.Students
            where student.Email.Contains("@abv.bg")
            select student;

        foreach (var student in filterStudentsByEmailDomain)
        {
            Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Email);
        }
    }
}

