using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class FilterText
{
    static void Main(string[] args)
    {
        string[] bannedWords = Regex.Split(Console.ReadLine(), ", ");
        string text = Console.ReadLine();

        string correctedText = null;
        
        for (int i = 0; i < bannedWords.Length; i++)
        {
            if (i==0)
            {
                correctedText = Regex.Replace(text, bannedWords[i], new string('*', bannedWords[i].Length));
            }
            else
            {
                correctedText = Regex.Replace(correctedText, bannedWords[i], new string('*', bannedWords[i].Length));
            }          
        }

        Console.WriteLine(correctedText);
    }
}

