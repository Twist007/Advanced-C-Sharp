
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class RageQuit
{
    static void Main()
    {
        string input = System.Console.ReadLine();
        Regex regex=new Regex(@"(\D+)(\d+)");

        MatchCollection matches = regex.Matches(input);
        StringBuilder builder=new StringBuilder();
        foreach (Match match in matches)
        {
            StringBuilder strBulber=new StringBuilder();
            var message = match.Groups[1].Value.ToUpper();
            var numOfRepetition = int.Parse(match.Groups[2].Value);

            for (int i = 0; i < numOfRepetition; i++)
            {
                strBulber.Append(message);
            }
            builder.Append(strBulber);
        }
        //var set=new HashSet<char>(); // пази уникални числа
        //foreach (char c in builder.ToString())
        //{
        //    set.Add(c);
        //}

        int count = builder.ToString().Distinct().Count();
        Console.WriteLine("Unique symbols used: {0}", count); //set.Count
        Console.WriteLine(builder);
    }
}

