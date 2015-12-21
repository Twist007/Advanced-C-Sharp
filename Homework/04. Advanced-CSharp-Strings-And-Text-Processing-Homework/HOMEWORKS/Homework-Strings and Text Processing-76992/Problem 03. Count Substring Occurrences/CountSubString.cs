using System;
using System.Text.RegularExpressions;


class CountSubString
{
    static void Main()
    {
        string text = Console.ReadLine().ToLower();
        string searchingPhrase = Console.ReadLine().ToLower();

        int counter = 0;

        Regex regex = new Regex(searchingPhrase);

        Match match = regex.Match(text);

        while (match.Success)
        {
            
            match = match.NextMatch();
            counter++;
        }

        Console.WriteLine(counter);
    }
}

