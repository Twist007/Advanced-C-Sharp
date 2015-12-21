using System;
using System.Collections.Generic;
using ClassStudentData;


public static class PrintStudentInfo
{
    public static void PrintInfo(this IEnumerable<Student> data)
    {
        foreach (var student in data)
        {
            Console.WriteLine(
                "First Name = {0}, Last Name = {1}, Age = {2}, Faculty Number = {3}, Phone = {4}, Email = {5}, Marks = {6}, Group Number = {7}",
                student.FirstName, student.LastName, student.Age, student.FacultyNumber, student.Phone, student.Email,
                string.Join(", ", student.Marks), student.GroupNumber);
        }
    }
}

