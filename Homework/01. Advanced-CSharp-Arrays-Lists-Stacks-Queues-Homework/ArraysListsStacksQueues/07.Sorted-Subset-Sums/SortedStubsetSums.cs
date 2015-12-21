//Modify the program you wrote for the previous problem to print the results in the following way: each line should contain the operands (numbers that form the desired sum) in ascending order; the lines containing fewer operands should be printed before those with more operands; when two lines have the same number of operands, the one containing the smallest operand should be printed first. If two or more lines contain the same number of operands and have the same smallest operand, the order of printing is not important.
using System;
using System.Collections.Generic;
using System.Linq;
class SortedStubsetSums
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] arrNumbers = Console.ReadLine().Split().Distinct().Select(int.Parse).ToArray();

        double combinations = Math.Pow(2, arrNumbers.Length);
        List<List<int>> subsets = new List<List<int>>();

        Console.WriteLine();

        for (int i = 1; i < combinations; i++)
        {
            List<int> currComb = new List<int>();
            for (int j = 0; j < arrNumbers.Length; j++)
            {
                int mask = i & (1 << j);
                if (mask != 0)
                {
                    currComb.Add(arrNumbers[j]);
                }
            }

            if (currComb.Sum() == number)
            {
                subsets.Add(currComb);
            }
        }

        if (subsets.Count != 0)
        {
            foreach (var list in subsets)
            {
                list.Sort();
            }

            subsets = subsets.OrderBy(a => a.Count).ThenBy(b => b.First()).ToList();

            foreach (var list in subsets)
            {
             Console.WriteLine("{0} = {1} ", string.Join(" + ", list), number);
            }
        }
        else
        {
            Console.WriteLine("No matching subsets.");
        }
    }
}

