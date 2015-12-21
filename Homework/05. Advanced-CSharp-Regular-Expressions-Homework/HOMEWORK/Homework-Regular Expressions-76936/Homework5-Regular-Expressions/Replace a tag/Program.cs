using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem_2.Replace_a_tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<string> output = new List<string>();

            do
            {
                input = Console.ReadLine();

                string temp = input.Trim('"');

                if (temp.Contains("<a href="))
                {
                    temp = Regex.Replace(temp, "<a href=\"(?<url>.+)\">(?<text>.+)</a>",
                                               "[URL href=$1]$2[/URL]");

                    temp = Regex.Replace(temp, "<a href='(?<url>.+)'>(?<text>.+)</a>",
                                               "[URL href=$1]$2[/URL]");
                }

                output.Add(temp);
                
            }
            while (!input.Contains(">\""));

            output.ForEach(Console.WriteLine);
        }
    }
}
