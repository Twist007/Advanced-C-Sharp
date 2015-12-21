//Write a program that reads a keyword and some text from the console and prints all sentences from the text, containing that word. A sentence is any sequence of words ending with '.', '!' or '?'. Examples:
using System;
using System.Text.RegularExpressions;

   class SentenceExtractor
    {
        static void Main()
        {

        string word = Console.ReadLine();
        string text = Console.ReadLine();
        string pattern = string.Format(@"\w+[\w\s]+\b{0}\b[\w\s]+[.|!|?]", word);

        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(text);
        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }

    }
    }

