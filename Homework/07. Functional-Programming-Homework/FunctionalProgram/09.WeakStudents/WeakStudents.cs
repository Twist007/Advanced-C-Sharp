//Write a similar program to the previous one to extract the students with exactly two marks "2". Use extension methods

using System;
using System.Collections.Generic;
using System.Linq;
    using ClassStudentData;

 public static class WeakStudents
    {
     public  static void Main()
        {
        StudentsData data=new StudentsData();

        var weakStudentList = data.Students.WeakList();

        foreach (var student in weakStudentList)
        {
            Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, string.Join(", ", student.Marks));
        }

    }

    public static List<Student> WeakList(this List<Student> students)
    {
        var WeakStudents =
            from student in students
            where (student.Marks.Count(mark => mark == 2) == 2)
            select student;

        return WeakStudents.ToList();

    }
    }
