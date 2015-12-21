using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<string> emails = new List<string>();
        string pattern = @"(?<=\s|^)([^\W_][\w.-]*[^\W_]|[^\W_])@[^\W_](([a-zA-Z-]*[a-zA-Z]+|[a-zA-Z]*)\.([a-zA-Z]+[a-zA-Z-]*|[a-zA-Z]*))+[^\W_]\b";
        Regex expression = new Regex(pattern, RegexOptions.Multiline);
        Match isEmail = expression.Match(input);
        while (isEmail.Success)
        {
            emails.Add(isEmail.Value);
            isEmail = isEmail.NextMatch();
        }
        foreach (var email in emails)
        {
            Console.WriteLine(email);
        }
    }
}