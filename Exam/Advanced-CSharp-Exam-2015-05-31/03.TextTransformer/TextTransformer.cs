using System;
using System.Text;
using System.Text.RegularExpressions;

public class TextTransformer
{
    public static void Main()
    {
        string line = Console.ReadLine();

        StringBuilder sb = new StringBuilder();

        while (line != "burp")
        {
            sb.Append(line);
            line = Console.ReadLine();
        }

        string text = Regex.Replace(sb.ToString(), @"\s{2,}", " ");

        Regex pattern = new Regex(@"([$%&'])([^$%&']+)\1");

        MatchCollection matches = pattern.Matches(text);

        StringBuilder currentWord = new StringBuilder();

        foreach (Match match in matches)
        {
            string output = match.Groups[2].Value;
            int weight;

            switch (match.Groups[1].Value)
            {
                case "$":
                    weight = 1;
                    break;
                case "%":
                    weight = 2;
                    break;
                case "&":
                    weight = 3;
                    break;
                default:
                    weight = 4;
                    break;
            }
            
            for (int i = 0; i < output.Length; i++)
            {
                char resultSymbol;

                if (i % 2 == 0)
                {
                    resultSymbol = (char)(output[i] + weight);
                }
                else
                {
                    resultSymbol = (char)(output[i] - weight);
                }

                currentWord.Append(resultSymbol);
            }

            currentWord.Append(" ");
        }

        Console.Write(currentWord);
    }
}