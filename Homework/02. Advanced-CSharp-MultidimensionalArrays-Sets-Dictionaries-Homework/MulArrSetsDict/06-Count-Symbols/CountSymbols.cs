//Write a program that reads some text from the console and counts the occurrences of each character in it.Print the results in alphabetical(lexicographical) order.
using System;
using System.Collections.Generic;
using System.Linq;
  class CountSymbols
    {
        static void Main()
        {
        string text = Console.ReadLine();

        SortedDictionary<char, int> characters = new SortedDictionary<char, int>();

        foreach (var ch in text)
        {
            if (characters.ContainsKey(ch))
            {
                characters[ch]++;
            }
            else
            {
                characters.Add(ch, 1);
            }
        }

        char[] charKeys = characters.Keys.ToArray();

        foreach (var key in charKeys)
        {
            Console.WriteLine("{0}: {1} time/s", key, characters[key]);
        }

    }
    }

