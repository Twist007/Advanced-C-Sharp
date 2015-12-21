using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

internal class ShmoogleCounter
{
    private static void Main()
    {
        var stBuilder = new StringBuilder();

        string text = Console.ReadLine();
        while (text != "//END_OF_CODE")
        {
            stBuilder.AppendLine(text);
            text = Console.ReadLine();
        }

        Regex regex = new Regex(@"((double) ([A-z0-9]+))");
        Regex regInt = new Regex(@"((int) ([A-z0-9]+))");
        var maches = regex.Matches(stBuilder.ToString());
        var intMaches = regInt.Matches(stBuilder.ToString());
        List<string> doubleList = new List<string>();
        List<string> intList = new List<string>();

        foreach (Match match in maches)
        {
            if (match.Groups[2].Value == "double")
            {
                doubleList.Add(match.Groups[3].Value);
            }
        }
        foreach (Match match in intMaches)
        {
            if (match.Groups[2].Value == "int")
            {
                intList.Add(match.Groups[3].Value);
            }
        }

        doubleList.RemoveAll(x => x == "double");
        intList.RemoveAll(i => i == "int");
        doubleList.Sort();
        intList.Sort();
        
        if (doubleList.Count != 0)
        {
            Console.WriteLine("Doubles: {0}", string.Join(", ", doubleList));
        }
        else
        {
            Console.WriteLine("Doubles: None");
        }
        if (intList.Count != 0)
        {
            Console.WriteLine("Ints: {0}", string.Join(", ", intList));
        }
        else
        {
            Console.WriteLine("Ints: None");
        }
    }
}


