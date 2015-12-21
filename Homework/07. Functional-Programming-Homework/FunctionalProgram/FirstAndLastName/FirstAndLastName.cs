//Print all students whose first name is before their last name alphabetically. Use a LINQ query.
using System;
using System.Linq;
using ClassStudentData;
namespace FirstAndLastName
{
     class FirstAndLastName
    {
        private static void Main()
        {
        StudentsData data = new StudentsData();

            var studentsByGroup =
                from student in data.Students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

        data.Students.PrintInfo();
        }
    }
}
