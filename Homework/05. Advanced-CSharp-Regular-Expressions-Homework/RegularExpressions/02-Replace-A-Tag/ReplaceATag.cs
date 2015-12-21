//Write a program that replaces in a HTML document given as string all the tags <a href=…>…</a> with corresponding tags [URL href=…]…[/URL]. Print the result on the console. The value of the href attribute can be enclosed in single or double quotes.The opening quotes must be the same as the closing closed (e.g. this is invalid: href= 'softuni.bg").

using System;
using System.Text.RegularExpressions;
   class ReplaceATag
    {
        static void Main()
        {
         string input= @"<ul> < li >  < a href = ""http://softuni.bg"" > SoftUni </ a >  </ li > </ ul > ";

        string pattern = @"<a.*href=((?:.|\n)*?(?=>))>((?:.|\n)*?(?=<))<\/a>";
        string newPattern = @"[URL href=$1]$2[/URL]";
        var repl = Regex.Replace(input, pattern, newPattern);

        Console.WriteLine(repl);
        }
    }

