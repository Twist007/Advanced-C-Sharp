using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SubSetSums
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] seq = n.Distinct().ToArray();

        double combinations = Math.Pow(2, seq.Length);

        List<int> intList = new List<int>();
        int count = 0;

        for (int i = 1; i < combinations; i++)
        {
            int sum = 0;
            CheckCombination(i, seq, ref intList);
            sum = intList.Sum();

            if (sum == num)
            {
                Console.WriteLine("{0} = {1}",
                    string.Join(" + ", intList.Select(x => x.ToString()).ToArray()),
                    intList.Sum()
                    );
                count++;
            }

            intList = new List<int>();
        }
        if (count == 0)
        {
            Console.WriteLine("No matching subsets.");
        }
    }

    private static void CheckCombination(int mask, int[] intArr, ref List<int> intList)
    {
        int sumOfComb = 0;
        for (int i = 0; i < intArr.Length; i++)
        {
            if (mask % 2 != 0)
            {
                sumOfComb += intArr[i];
                intList.Add(intArr[i]);
                
            }
            mask >>= 1;

        }
    }
}