//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
using System;
using System.Text.RegularExpressions;
  class SeriesOfLetters
    {
        static void Main()
        {

        string input = Console.ReadLine();
        string pattern;
        Regex regex;

        for (int i = 0; i < input.Length; i++)
        {
            pattern = string.Format(@"{0}+", input[i]);
           string  patternReplace = string.Format(@"{0}", input[i]);
            regex = new Regex(pattern);

            input = regex.Replace(input, patternReplace);
        }

        Console.WriteLine(input);

        }
    }
