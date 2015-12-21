using System;
using System.Collections.Generic;
using System.Linq;

class InsertionSort
{
    static void Main()
    {
        int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 1; i < num.Length; i++)
        {
            int x = num[i];
            int j = i;

            while (j > 0 && num[j - 1] > x)
            {
           
                int temp = num[j - 1];
                num[j - 1] = num[j];
                num[j] = temp;
                j = j - 1;
            }
          
        }

        Console.WriteLine(string.Join(" ", num));
    }
}
