//You are given n numbers. Write a program to find among these numbers all sets of 4 numbers {a, b, c, d}, such that a|b == c|d, where a ≠ b ≠ c ≠ d. Assume that "a|b" means to append the number b after a. We call these numbers {a, b, c, d} stuck numbers: if we append a and b, we get the same result as if we appended c and d. Note that the numbers a, b, c and d should be distinct (a ≠ b ≠ c ≠ d).
using System;
using System.Collections.Generic;
using System.Linq;

class StuckNumbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int[] arrNum = Console.ReadLine().Split().Select(int.Parse).ToArray();

        bool noStuck = false;

        for (int a = 0; a < num; a++)
        {
            for (int b = 0; b < num; b++)
            {
                for (int c = 0; c < num; c++)
                {
                    for (int d = 0; d < num; d++)
                    {
                        if (arrNum[a] != arrNum[b] && arrNum[a] != arrNum[c] && arrNum[a] != arrNum[d] && arrNum[b] != arrNum[c] && arrNum[b] != arrNum[d] && arrNum[c] != arrNum[d])
                        {
                            string left = "" + arrNum[a] + arrNum[b];
                            string right = "" + arrNum[c] + arrNum[d];

                            if (left.Equals(right))
                            {
                                noStuck = true;
                                Console.WriteLine("{0}|{1}=={2}|{3}", arrNum[a], arrNum[b], arrNum[c], arrNum[d]);
                            }
                        }
                    }
                }
            }
        }
        if (!noStuck)
        {
            Console.WriteLine("No");
        }
    }
}

