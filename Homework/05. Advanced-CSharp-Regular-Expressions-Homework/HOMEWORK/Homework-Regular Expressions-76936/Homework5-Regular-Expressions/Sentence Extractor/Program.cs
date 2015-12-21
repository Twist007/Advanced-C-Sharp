using System;
using System.Text.RegularExpressions;

namespace Problem_4.Sentence_Extractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();

            foreach (var match in Regex.Matches(text, "[A-Z].*? " + keyword + @" .*?[!.?](?=\s)"))
            {
                Console.WriteLine(match);
            }
        }
    }
}
