//Print all students from group number 2. Use a LINQ query. Order the students by FirstName.
using System;
using System.Linq;
using ClassStudentData;

class StudentsByGroup
{
    static void Main()
    {

        StudentsData data = new StudentsData();

        var studentsByGroupQueary =
            from studentList in data.Students
            where studentList.GroupNumber == 2
            orderby studentList.FirstName
            select studentList;

        data.Students.PrintInfo();

    }
}

