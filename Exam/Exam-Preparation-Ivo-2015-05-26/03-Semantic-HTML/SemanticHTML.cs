using System;
using System.Text.RegularExpressions;

class SemanticHTML
{
    static void Main()
    {
        var openTagPattern = @"(\s*)<div(\s*.+)?\s+\w+\s?=\s?""(\w+)""\s*(\s.+)?>";
        var closeTagPattern = @"(\s*)<\/div>\s+<!--\s*(\w+)\s*-->";
       

        var line = Console.ReadLine();
        while (line != "END")
        {

            if (Regex.IsMatch(line, openTagPattern))
            {
                var matches = Regex.Match(line, openTagPattern);
                var tagName = matches.Groups[3].Value;
                var before = matches.Groups[2].Value;
                var spaces = matches.Groups[1].Value;
                var after = matches.Groups[4].Value;
                var result = spaces+"<" + tagName + before + after + ">";
                Console.WriteLine(result);
            }
            else if (Regex.IsMatch(line, closeTagPattern))
            {
                var matches = Regex.Match(line, closeTagPattern);
                var tagname = matches.Groups[2].Value;
                var spaces = matches.Groups[1].Value;
                var result = spaces+"</" + tagname + ">";
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine(line);
            }

            line = Console.ReadLine();
        }
    }
}

