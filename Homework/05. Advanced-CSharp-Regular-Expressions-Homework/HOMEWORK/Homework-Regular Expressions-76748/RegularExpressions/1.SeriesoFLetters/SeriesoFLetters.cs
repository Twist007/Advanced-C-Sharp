using System;
using System.Text.RegularExpressions;

class SeriesoFLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        string output = Regex.Replace(input, @"(\w)\1*", "$1");
        Console.WriteLine(output);
    }
}