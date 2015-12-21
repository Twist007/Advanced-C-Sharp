using System;
using System.Text.RegularExpressions;

class Replace_a_Tag
{
    static void Main()
    {
        string HTMLcode = Console.ReadLine();
        string pattern = @"<a(.*href=(.|\n)*?(?=>))>((.|\n)*?(?=<))<\/a>";
        string replacement = @"[URL$1]$3[/URL]";
        string newHTMLcode = Regex.Replace(HTMLcode, pattern, replacement);
        Console.WriteLine(newHTMLcode);
    }
}