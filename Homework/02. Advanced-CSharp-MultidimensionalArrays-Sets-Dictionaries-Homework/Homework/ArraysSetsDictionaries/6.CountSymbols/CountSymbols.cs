using System;
using System.Collections.Generic;
class CountSymbols
{
    static void Main()
    {
        string input = Console.ReadLine();
        SortedDictionary<char, int> counter = new SortedDictionary<char, int>();

        foreach (char character in input)
        {
            if (counter.ContainsKey(character))
            {
                counter[character] += 1;
            }
            else
            {
                counter[character] = 1;
            }
        }

        foreach (var item in counter)
        {
            Console.WriteLine("{0}: {1} time/s", item.Key, item.Value);
        }
    }
}
