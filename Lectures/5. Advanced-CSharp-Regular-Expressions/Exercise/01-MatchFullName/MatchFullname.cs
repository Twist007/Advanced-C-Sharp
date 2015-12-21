using System;
using System.Text.RegularExpressions;

static class MatchFullname
{
    static void Main()
    {
        string input = "ivan ivanov, Ivan ivanov, Ivan Ivanov ivan Ivanov, IVan Ivanov, Ivan IvAnov, Ivan	Ivanov Ivan Ivanov";
        Regex regex = new Regex(@"\b[A-Z][a-z]{2,} [A-Z][a-z]{2,}\b");
        Match regMatch = regex.Match(input);

        Console.WriteLine(regMatch);

    }
}
