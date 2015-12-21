//Extract and print the Marks of the students that enrolled in 2014 (the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber)

using System;
using System.Linq;
using ClassStudentData;

class StudentsEnrolledIn2014
    {
        static void Main()
        {
        StudentsData data = new StudentsData();

            var studentsEnrolledIn2014 =
                from student in data.Students
                where(student.FacultyNumber.EndsWith("14"))
                select student;

        foreach (var student in studentsEnrolledIn2014)
        {
            Console.WriteLine("{0} {1} -> {2}", student.FirstName, student.LastName, student.FacultyNumber);
        }

    }
}

