using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class SentenceExtractor
{
    static void Main(string[] args)
    {
        string word = string.Format(@"\b{0}\b", Console.ReadLine());
        string inputText = Console.ReadLine();

        string pattern = @"[^!.?]*" + word + @"[^!.?]*[!.?]";
        Regex expression = new Regex(pattern, RegexOptions.IgnoreCase);
        Match m = expression.Match(inputText);
        List<string> sentences = new List<string>();

        while (m.Success)
        {
            sentences.Add(m.Value.Trim());
            m = m.NextMatch();
        }

        foreach (var sentence in sentences)
        {
            Console.WriteLine(sentence);
        }
    }
}