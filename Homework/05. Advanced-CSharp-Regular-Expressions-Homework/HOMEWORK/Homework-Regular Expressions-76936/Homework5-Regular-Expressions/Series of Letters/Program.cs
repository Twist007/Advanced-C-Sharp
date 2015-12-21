using System;
using System.Text.RegularExpressions;

namespace Problem_1.Series_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string reducedString = Regex.Replace(input, @"(.)\1+", "$1");

            Console.WriteLine(reducedString);
        }
    }
}
