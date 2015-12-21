using System;
using System.Collections.Generic;
using System.Linq;

class SequencesEqualStrings
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        var groups = input.GroupBy(name => name);
        foreach (var group in groups)
        {
            Console.WriteLine(string.Join(" ",group));
        }
        Console.WriteLine();
    }
}