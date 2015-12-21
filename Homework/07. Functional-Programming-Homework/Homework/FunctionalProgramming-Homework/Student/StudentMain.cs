using System;
using System.Collections.Generic;

namespace Student
{
    class StudentMain
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Dian","Kirilov",22,807114,"+359 28410072","dian.kirilov@gmail.com",new List<int>{2,3,4,5},1,"Idiots"),
                new Student("Pavel","Pavlov",20,378221,"+35929812233","pavlov@mail.bg",new List<int>{6,5,4,4},1,"Idiots"),
                new Student("Krasimir","Kirilov",24,245134,"0899856734","kirilov@abv.bg",new List<int>{3,3,4,5},2,"Fools"),
                new Student("Nikolai","Nikolov",25,343514,"02345670","nikolai.nikolov@gmail.com",new List<int>{2,5,6,2},2,"Fools"),
                new Student("Georgi","Georgiev",30,456115,"0898769787","gosho@mail.bg",new List<int>{2,2,4,4},3,"Cretins"),
                new Student("Stamen", "Georgiev",27,878989,"767899089","sgeorgiev@abv.bg",new List<int>{5,5,4,3},3,"Cretins")
            };

            /* Remove the comment before the function that you want to test */
                 //StudentFunctions.StudentsByGroup(students);
                 //StudentFunctions.StudentsByFirstAndLastName(students);
                 // StudentFunctions.StudentsByAge(students);
                 //StudentFunctions.SortStudentsLambda(students);
                 //StudentFunctions.SortStudentsLINQ(students);
                 //StudentFunctions.FilterByEmailDomain(students);
                 //StudentFunctions.FilterByPhone(students);
                 //StudentFunctions.ExcellentStudents(students);
                 //StudentFunctions.WeakStudents(students);
                 //StudentFunctions.StudentsEnrolledIn2014(students);
                 //StudentFunctions.StudentsByGroups(students);
        }
    }
}
