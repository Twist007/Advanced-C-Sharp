//Write a program that converts a string to a sequence of C# Unicode character literals. 
using System;

    class UnicodeCharacters
    {
        static void Main()
        {
        string word = Console.ReadLine();
        for (int i = 0; i < word.Length; i++)
        {
            Console.Write("\\u{0:x4}", (int)word[i]);

        }
        Console.WriteLine();

    }
    }
