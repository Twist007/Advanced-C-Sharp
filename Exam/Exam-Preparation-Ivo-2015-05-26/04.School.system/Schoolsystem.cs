using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Schoolsystem
{
    static void Main()
    {

        var students = new SortedDictionary<string, SortedDictionary<string, List<double>>>();
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            var student = Console.ReadLine().Split();
            var fullName = student[0] + " " + student[1];
            var subject = student[2];
            var marks = double.Parse(student[3]);

            if (students.ContainsKey(fullName))
            {
                if (students[fullName].ContainsKey(subject))
                {
                    students[fullName][subject].Add(marks);
                }
                else
                {
                    var markses = new List<double>();
                    markses.Add(marks);
                    students[fullName].Add(subject, markses);
                }
            }
            else
            {
                var subjects = new SortedDictionary<string, List<double>>();
                var markses = new List<double>();
                markses.Add(marks);
                subjects.Add(subject, markses);
                students.Add(fullName, subjects);
            }
        }

        foreach (var student in students)
        {
            var sub = student.Value.Select(x => x.Key + " - " + x.Value.Average().ToString("0.00")).Aggregate((x, y) => x + ", " + y);//Aggregate-> razdelq selectnatite neshta po ,
            Console.WriteLine("{0}: [{1}]", student.Key, sub);

            //ne raboti korektno
            //var result =new StringBuilder();
            //result.Append(student.Key + " : [");
            //foreach (var subjects in student.Value)
            //{
            //    result.Append(subjects.Key + " - " + subjects.Value.Average().ToString("0.00")+", ");
            //}
            //result.Remove(result.Length - 2, 2);
            //result.Append("]");
            //Console.WriteLine(result);
        }
    }
}

