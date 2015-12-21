using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Symbols
{
    static void Main()
    {
        string input = Console.ReadLine();
        SortedDictionary<char, int> occurences = new SortedDictionary<char, int>();
        foreach (char symbol in input)
        {
            if (occurences.ContainsKey(symbol))
            {
                occurences[symbol]++;
            }
            else
            {
                occurences.Add(symbol, 1);
            }
            
        }

        foreach (KeyValuePair<char, int> pair in occurences)
        {
            Console.WriteLine("{0}: {1} time/s", pair.Key, pair.Value);
        }
    }
}
