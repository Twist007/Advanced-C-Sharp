using System;
class MaximalSum
{
    static void Main()
    {
        Console.WriteLine(" This program reads a rectangular integer matrix of size N x M and finds in it the square 3 x 3 thet has maximal sum of its elements.");
        Console.Write("N= ");
        int row = int.Parse(Console.ReadLine());
        Console.Write("M= ");
        int col = int.Parse(Console.ReadLine());
        int[,] matrix = new int[row, col];

        for (int i = 0; i < row; i++)
        {
            string line = Console.ReadLine();
            int[] lineAsArr = Array.ConvertAll(line.Split(' '), int.Parse);
            for (int j = 0; j < col; j++)
            {
                matrix[i, j] = lineAsArr[j];
            }
        }

        int maxSum = int.MinValue;
        int tempSum = 0;
        int rowOfResult = 0;
        int colOfResult = 0;

        for (int r = 0; r < matrix.GetLength(0)-2; r++)
        {
            for (int c = 0; c < matrix.GetLength(1)-2; c++)
            {
                tempSum = matrix[r, c] + matrix[r, c + 1] + matrix[r, c + 2] +
                          matrix[r + 1, c] + matrix[r + 1, c + 1] + matrix[r + 1, c + 2] +
                          matrix[r + 2, c] + matrix[r + 2, c + 1] + matrix[r + 2, c + 2];

                if (maxSum < tempSum)
                {
                    maxSum = tempSum;
                    rowOfResult = r;
                    colOfResult = c;
                }
            }
        }
        Console.WriteLine("Sum = {0}", maxSum);
        for (int r = rowOfResult; r < rowOfResult+3; r++)
        {
            for (int c = colOfResult; c < colOfResult+3; c++)
            {
                Console.Write(matrix[r,c] + " ");
            }
            Console.WriteLine();
        }
    }
}
