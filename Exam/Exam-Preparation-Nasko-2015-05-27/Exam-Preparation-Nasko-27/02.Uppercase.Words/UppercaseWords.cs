using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

class UppercaseWords
{
    static void Main()
    {
        StringBuilder line = new StringBuilder(Console.ReadLine());
        // string line = Console.ReadLine();

        Regex regex = new Regex(@"(?<![]A-z])[A-Z]+(?![A-z])");

        while (line.ToString() != "END")
        {
            MatchCollection matches = regex.Matches(line.ToString());
            int offset = 0;

            foreach (Match match in matches)
            {
                string word = match.Value;
                var rev = word.ToArray().Reverse();

                string reversed = string.Join("", rev);

                if (reversed == word)
                {
                    reversed = DoubleEachLetter(reversed);
                }

                int index = match.Index;
                //line = line.Remove(index + offset, word.Length);
                //line = line.Insert(index + offset, reversed);
                line.Remove(index + offset, word.Length);
                line.Insert(index + offset, reversed);
                offset += reversed.Length - word.Length;
            }

            Console.WriteLine(SecurityElement.Escape(line.ToString()));
            line = new StringBuilder(Console.ReadLine());
            // line = Console.ReadLine();
        }
    }

    private static string DoubleEachLetter(string reversed)
    {
        StringBuilder doubleString = new StringBuilder();
        for (int i = 0; i < reversed.Length; i++)
        {
            doubleString.Append(new string(reversed[i], 2));
        }
        return doubleString.ToString();
    }
}

