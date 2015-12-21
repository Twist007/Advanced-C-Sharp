//Write two programs that fill and print a matrix of size N x N. Filling a matrix in the regular pattern (top to bottom and left to right) is boring. Fill the matrix as described in both patterns below:

using System;
class FillTheMatrix
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int[,] patternA = new int[num, num];
        int[,] patternB = new int[num, num];

        int number = 1;
        for (int row = 0; row < num; row++)
        {
            for (int col = 0; col < num; col++)
            {
                patternA[row, col] = number++;
            }
        }

        Console.WriteLine();

        for (int row = 0; row < num; row++)
        {
            for (int col = 0; col < num; col++)
            {
                Console.Write(" "+patternA[col, row]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        number = 1;
        for (int row = 0; row < num; row++)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < num; col++)
                {
                    patternB[col, row] = number++;
                }
            }

            else
            {
                for (int col = num - 1; col >= 0; col--)
                {
                    patternB[col, row] = number++;
                }
            }

        }

        for (int row = 0; row < num; row++)
        {
            for (int col = 0; col < num; col++)
            {
                Console.Write(" "+patternB[row, col]);
            }

            Console.WriteLine();
        }
    }
}

