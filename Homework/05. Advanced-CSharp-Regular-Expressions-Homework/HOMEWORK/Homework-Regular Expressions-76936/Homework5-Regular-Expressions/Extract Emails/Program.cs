using System;
using System.Text.RegularExpressions;

namespace Problem_3.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            foreach (var match in Regex.Matches(input, @"\b[A-Za-z0-9]+\S*[A-Za-z0-9]+@[A-Za-z0-9]+\S*[A-Za-z0-9]+"))
            {
                Console.WriteLine(match);
            }
        }
    }
}
