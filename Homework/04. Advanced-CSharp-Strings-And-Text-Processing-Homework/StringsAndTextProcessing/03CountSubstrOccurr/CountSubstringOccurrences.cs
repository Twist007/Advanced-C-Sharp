//Write a program to find how many times a given string appears in a given text as substring.The text is given at the first input line.The search string is given at the second input line. The output is an integer number.Please ignore the character casing.Overlapping between occurrences is allowed.
using System;

    class CountSubstringOccurrences
    {
        static void Main()
        {
        string text = Console.ReadLine().ToLower();
        string word = Console.ReadLine().ToLower();

        int counter = 0;

        for (int i = 0; i <= text.Length-word.Length; i++)
        {
            if (word.Equals(text.Substring(i, word.Length)))
            {
                counter++;
            }
        }

        Console.WriteLine(counter);
        }
    }

