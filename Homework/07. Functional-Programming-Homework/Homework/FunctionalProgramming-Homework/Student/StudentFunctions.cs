using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Student
{
    public static class Extension
    {
        public static int Matches(this IList<int> list, int number)
        {
            return list.Count(match => match.Equals(number));
        }
    }

    public class StudentFunctions
    {
        public static void StudentsByGroup(IList<Student> students)
        {
            // This is the solution of  "Problem 2.	Students by Group"
            var studentsByGroup = from student in students
                                  where student.GroupNumber == 2
                                  orderby student.FirstName
                                  select student;
            Console.WriteLine("Students from group 2:");
            foreach( var student in studentsByGroup)
            {
                PrintStudentInfo(student);
            }
        }

        public static void StudentsByFirstAndLastName(IList<Student> students)
        {
            // This is the solution of "Problem 3.	Students by First and Last Name"
            var studentsByFirstAndLastName = from student in students
                                             where String.Compare(student.FirstName, student.LastName) < 0
                                             select student;
            Console.WriteLine("\nStudents whose first name is before their last name alphabetically:");
            foreach (var student in studentsByFirstAndLastName)
            {
                PrintStudentInfo(student);
            }
        }

        public static void StudentsByAge(IList<Student> students)
        {
            // This is the solution of "Problem 4.	Students by Age"
            var studentsByAge = from student in students
                                where student.Age >= 18 && student.Age <= 24
                                select new { student.FirstName, student.LastName, student.Age };
            Console.WriteLine("Students by age:");
            foreach (var student in studentsByAge)
            {
                Console.WriteLine("Name: {0} {1}, Age: {2}",student.FirstName,student.LastName,student.Age);
            }
        }

        public static void SortStudentsLambda(IList<Student> students)
        {
            // This is the solution of "Problem 5.	Sort Students", solved with lambda expressions 
            var sortStudents = students.Select(student => student)
                                       .OrderByDescending(student => student.FirstName)
                                       .ThenByDescending(student => student.LastName);
            Console.WriteLine("Sorted students with lambda: ");
            foreach (var student in sortStudents)
            {
                PrintStudentInfo(student);
            }
        }

        public static void SortStudentsLINQ(IList<Student> students)
        {
            // This is the solution of "Problem 5.	Sort Students", solved with LINQ
            var sortStudents = from student in students
                               orderby student.FirstName descending, student.LastName descending
                               select student;
            Console.WriteLine("Sorted students with LINQ: ");
            foreach (var student in sortStudents)
            {
                PrintStudentInfo(student);
            }
        }

        public static void FilterByEmailDomain(IList<Student> students)
        {
            // This is the solution of "Problem 6.	Filter Students by Email Domain"
            var studentsByEmailDomain = from student in students
                                        where student.Email.Contains("@abv.bg")
                                        select student;
            Console.WriteLine("Students whose email domain is @abv.bg: ");
            foreach (var student in studentsByEmailDomain)
            {
                PrintStudentInfo(student);
            }
        }

        public static void FilterByPhone(IList<Student> students)
        {
            // This is the solution of "Problem 7.	Filter Students by Phone"
            var studentsByPhone = from student in students
                                  where Regex.IsMatch(student.Phone,"^02|^\\+3592|^\\+359\\s2")
                                  select student;
            Console.WriteLine("Students whose phone number is from Sofia: ");
            foreach (var student in studentsByPhone)
            {
                PrintStudentInfo(student);
            }
        }

        public static void ExcellentStudents(IList<Student> students)
        {
            // This is the solution of "Problem 8.	Excellent Students"
            var excellentStudents = from student in students
                                    where student.Marks.Contains(6) 
                                    select new {FullName = String.Format("{0} {1}",student.FirstName,student.LastName),student.Marks};
            Console.WriteLine("Excellent students:");
            foreach (var student in excellentStudents)
            {
                Console.WriteLine("Full name: {0}, Marks: {1}",student.FullName,string.Join(";",student.Marks));
            }
        }

        public static void WeakStudents(IList<Student> students)
        {
            // This is the solution of "Problem 9.	Weak Students"
            var weakStudents = from student in students
                                    where student.Marks.Matches(2)==2
                                    select new { FullName = String.Format("{0} {1}", student.FirstName, student.LastName), student.Marks };
            Console.WriteLine("Weak students:");
            foreach (var student in weakStudents)
            {
                Console.WriteLine("Full name: {0}, Marks: {1}", student.FullName, string.Join(";", student.Marks));
            }
        }

        public static void StudentsEnrolledIn2014(IList<Student> students)
        {
            // This is the solution of "Problem 10.	Students Enrolled in 2014"
            var enrolledIn2014 = from student in students
                                 where Regex.IsMatch(student.FacultyNumber.ToString(), "14$")
                                 select new {FullName=String.Format("{0} {1}",student.FirstName,student.LastName), student.Marks };
            Console.WriteLine("Marks of the students enrolled in 2014: ");
            foreach (var student in enrolledIn2014)
            {
                Console.WriteLine("Student:{0}, Marks: {1}",student.FullName,string.Join(";",student.Marks));
            }
        }

        public static void StudentsByGroups(IList<Student> students)
        {
            // This is the solution of "Students by Groups" 
            var studentsByGroups = from student in students
                                   group student by student.GroupName into grp
                                   select grp;
            foreach (var group in studentsByGroups)
            {
                Console.WriteLine("Group \"{0}\"",group.ElementAt(0).GroupName);
                foreach (var student in group)
                {                    
                    PrintStudentInfo(student);
                }
            }
        }

        public static void PrintStudentInfo(Student student)
        {
            Console.WriteLine("  Name:{0} {1} \n  Age:{2} \n  Faculty number:{3} \n  Phone:{4} \n  Email:{5} \n  Marks:{6} \n  Group number:{7}\n",
                                   student.FirstName,
                                   student.LastName,
                                   student.Age,
                                   student.FacultyNumber,
                                   student.Phone,
                                   student.Email,
                                   string.Join(";", student.Marks),
                                   student.GroupNumber
                                 );
        }
    }
}
