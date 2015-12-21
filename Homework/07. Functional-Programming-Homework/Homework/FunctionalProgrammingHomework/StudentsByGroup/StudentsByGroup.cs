using ClassStudents;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsByGroup
{
    static class StudentsByGroup
    {
        static List<Students> studentsList = GenerateStudents();

        static void Main(string[] args)
        {
            ProblemTwo();
            ProblemThree();
            ProblemFour();
            ProblemFive();
            ProblemSix();
            ProblemSeven();
            ProblemEight();
            ProblemNine();
            ProblemTen();            
        }

        //Problem 10:
        private static void ProblemTen()
        {
            Console.WriteLine("Problem 10:");
            var enrolledStudents = studentsList.GetEnrolledStudents(2014);
            foreach (var student in enrolledStudents)
            {
                Console.WriteLine(string.Join(", ", student));
            }
            Console.WriteLine();
        }

        //Problem 9:
        private static void ProblemNine()
        {
            Console.WriteLine("Problem 9:");
            var WeakStudents = studentsList.GetWeakStudents();
            foreach (var student in WeakStudents)
            {
                Console.WriteLine(string.Join(", ", student));
            }
            Console.WriteLine();
        }

        //Problem 8:
        private static void ProblemEight()
        {
            Console.WriteLine("Problem 8:");
            var excellentStudents = studentsList.Where(student => student.Marks.Contains(6)).Select(student => student.FirstName + " " + student.LastName + " " + string.Join(", ", student.Marks));
            foreach (var student in excellentStudents)
            {
                Console.WriteLine(string.Join(", ", student));
            }
            Console.WriteLine();
        }

        //Problem 7:
        private static void ProblemSeven()
        {
            Console.WriteLine("Problem 7:");
            foreach (Students student in studentsList.Where(student =>
                                                            student.Phone.Contains("02") ||
                                                            student.Phone.Contains("+3592") ||
                                                            student.Phone.Contains("+359 2")))
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();
        }

        //Problem 6:
        private static void ProblemSix()
        {
            Console.WriteLine("Problem 6:");
            foreach (Students student in studentsList.Where(student => student.Email.Contains("@abv.bg")))
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();
        }

        //Problem 5:
        private static void ProblemFive()
        {
            Console.WriteLine("Problem 5:");
            foreach (Students student in studentsList.
                                                      OrderByDescending(student => student.FirstName).
                                                      ThenByDescending(student => student.LastName))
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();

        }

        //Problem 4:
        private static void ProblemFour()
        {
            Console.WriteLine("Problem 4:");
            foreach (Students student in studentsList.Where(student => student.Age >= 18 &&
                                                                       student.Age <= 24))
            {
                Console.WriteLine(student.PrintPersonalInfo());
            }
            Console.WriteLine();
        }

        //Problem 3:
        private static void ProblemThree()
        {
            Console.WriteLine("Problem 3:");
            foreach (Students student in studentsList.Where(student => student.LastName[0] > student.FirstName[0]))
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();
        }

        //Problem 2:
        private static void ProblemTwo()
        {
            Console.WriteLine("Problem 2:");
            foreach (Students student in studentsList.Where(student => student.GroupNumber == 2).
                                                      OrderBy(student => student.FirstName))
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();
        }

        //Generating the List of Students
        static List<Students> GenerateStudents()
        {
            return new List<Students>()
            {
                new Students()
                {
                    FirstName = "Sara",
                    LastName = "Mills",
                    Age = 14,
                    Email = "mills91@outlook.com",
                    FacultyNumber = "2038514",
                    GroupNumber = 10,
                    Marks = new List<int>() { 6, 5, 5, 6, 6, 6 },
                    Phone = "025554545"
                },

                new Students()
                {
                    FirstName = "George",
                    LastName = "Bills",
                    Age = 27,
                    Email = "GBillz@abv.bg",
                    FacultyNumber = "2034413",
                    GroupNumber = 2,
                    Marks = new List<int>() { 2, 3, 2, 5, 4, 5 },
                    Phone = "08963334654"
                },

                new Students()
                {
                    FirstName = "Sherry",
                    LastName = "Corleone",
                    Age = 22,
                    Email = "cutiepie22@hotmail.com",
                    FacultyNumber = "2156512",
                    GroupNumber = 10,
                    Marks = new List<int>() { 6, 4, 3, 5, 6, 3 },
                    Phone = "+35925553423"
                },

                new Students()
                {
                    FirstName = "How",
                    LastName = "Udoin",
                    Age = 29,
                    Email = "proffessorYY@outlook.com",
                    FacultyNumber = "2155414",
                    GroupNumber = 2,
                    Marks = new List<int>() { 6, 6, 6, 6, 6, 6 },
                    Phone = "0884346665"
                },

                new Students()
                {
                    FirstName = "Johny",
                    LastName = "Creek",
                    Age = 19,
                    Email = "mills91@abv.bg",
                    FacultyNumber = "2034314",
                    GroupNumber = 9,
                    Marks = new List<int>() { 3, 5, 4, 6, 6, 6 },
                    Phone = "+359 2 5554535"
                }
            };
        }

        //Extension Method - Gets the enrolled students based on year
        public static IEnumerable<string> GetEnrolledStudents(this List<Students> studentList, int year)
        {
            char firstPart = year.ToString()[2];
            char SecondPart = year.ToString()[3];
            var enrolledStudents = studentList.Where(student => student.FacultyNumber[student.FacultyNumber.Length - 2].Equals(firstPart) &&
                                                                student.FacultyNumber[student.FacultyNumber.Length - 1].Equals(SecondPart)).
                                               Select(student => string.Join(", ", student.Marks));
            return enrolledStudents;
        }

        //Extension Method - Gets the weak students
        public static IEnumerable<string> GetWeakStudents(this List<Students> studentList)
        {
            var weakStudents = studentList.Where(student => student.Marks.Contains(2)).
                                                Select(student => student.FirstName + " " + student.LastName + " " + string.Join(", ", student.Marks));
            return weakStudents;
        }
    }

}
