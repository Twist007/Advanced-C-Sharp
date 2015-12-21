using System;
using System.Text.RegularExpressions;


class Polidromes
{
    static void Main()
    {
        string text  = Console.ReadLine();

        string[] words = Regex.Split(text, @"\W" );

        string[] reversed = new string[words.Length];


        for (int i = 0; i < words.Length; i++)
        {
            reversed[i] = Reverse(words[i]);
        }

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == reversed[i])
            {
                Console.Write(words[i] + " ");
            }
        }
        Console.WriteLine();
    }

    public static string Reverse(string text)
    {
        if (text == null)
        return null;

        char[] array = text.ToCharArray();
        Array.Reverse(array);
        return new String(array);
    }
}

