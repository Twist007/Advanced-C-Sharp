//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe and prints them on the console on a single line, separated by comma and space. Use spaces, commas, dots, question marks and exclamation marks as word delimiters. Print only unique palindromes, sorted lexicographically. String comparison should be case-sensitive as shown in the example below.
using System;
using System.Text;
using System.Collections.Generic;

class Palindromes
    {
        static void Main()
        {
        string[] text = Console.ReadLine().Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> palindromes = new List<string>();

        for (int i = 0; i < text.Length; i++)
        {
         
            if (text[i]==ReversString(text[i]))
            {
                palindromes.Add(text[i]);
            }
        }

        palindromes.Sort();
        Console.WriteLine(string.Join(", ", palindromes));
        }

    static string ReversString(string word)
    {
        StringBuilder strBuilder = new StringBuilder();
        for (int i = word.Length - 1; i >= 0; i--)
        {
            strBuilder.Append(word[i]);
        }

        return (strBuilder.ToString());
    }
    }
