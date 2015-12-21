//Write a program that reads a rectangular integer matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements. On the first line, you will receive the rows N and columns M. On the next N lines you will receive each row with its columns. Print the elements of the 3 x 3 square as a matrix, along with their sum.

using System;
using System.Linq;
class MaximalSum
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[,] matrix = new int[input[0], input[1]];
        int bestSum = int.MinValue;
        int startRow = 0;
        int startCol = 0;

        for (int i = 0; i < input[0]; i++)
        {
            int[] numMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < input[1]; j++)
            {
                matrix[i, j] = numMatrix[j];
            }
        }

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum =
                    matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    startRow = row;
                    startCol = col;
                }
            }
        }

        Console.WriteLine("----------------");
        Console.WriteLine("Sum = {0}", bestSum);

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("{0} ", matrix[startRow + i, startCol + j]);
            }
            Console.WriteLine();
        }
    }
}

