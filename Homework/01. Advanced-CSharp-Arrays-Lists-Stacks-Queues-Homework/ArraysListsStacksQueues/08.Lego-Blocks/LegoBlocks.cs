//You are given two jagged arrays. Each array represents a Lego block containing integers. Your task is first to reverse the second jagged array and then check if it would fit perfectly in the first jagged array.
using System;
using System.Collections.Generic;
using System.Linq;
class LegoBlocks
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int[][] arrayOne = new int[rows][];
        int[][] arrayTwo = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            arrayOne[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

        for (int i = 0; i < rows; i++)
        {
            arrayTwo[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

        int counter = arrayOne[0].Length + arrayTwo[0].Length;
        int c = counter;
        bool fit = true;

        for (int i = 1; i < rows; i++)
        {
            counter += arrayOne[i].Length + arrayTwo[i].Length;

            if (arrayOne[i].Length + arrayTwo[i].Length!=c)
            {
                fit = false;
            }
        }

        if (!fit)
        {
            Console.WriteLine("The total number of cells is: {0}", counter);
        }
        else
        {
            for (int i = 0; i < rows; i++)
            {
                Array.Reverse(arrayTwo[i]);
                Console.WriteLine("[{0}, {1}]", string.Join(", ", arrayOne[i]), string.Join(", ", arrayTwo[i]));
            }
        }
    }
}

