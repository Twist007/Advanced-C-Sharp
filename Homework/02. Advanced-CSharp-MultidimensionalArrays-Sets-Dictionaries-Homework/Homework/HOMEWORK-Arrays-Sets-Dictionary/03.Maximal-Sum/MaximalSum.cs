using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MaximalSum
{
    static void Main()
    {
        var size = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = size[0];
        int cols = size[1];
        int[,] matrix = new int[rows, cols];
        int[,] platform = new int[3, 3];

        for(int row = 0; row < rows; row++)
        {
            int[] containerLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for(int col = 0; col < cols; col++)
            {
                matrix[row, col] = containerLine[col];
            }
        }

        int maxSum = int.MinValue;
        int platformRow = 0;
        int platformCol = 0;

        for(int row = 0; row < rows - 2; row++)
        {
            for(int col = 0; col < cols - 2; col++)
            {
                int sum =
                    matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if(sum > maxSum)
                {
                    maxSum = sum;
                    platformRow = row;
                    platformCol = col;
                }
            }
        }
        Console.WriteLine("Sum = {0}", maxSum);

        Console.WriteLine("{0} {1} {2}", 
            matrix[platformRow, platformCol], 
            matrix[platformRow, platformCol + 1],
            matrix[platformRow, platformCol + 2]);

        Console.WriteLine("{0} {1} {2}", 
            matrix[platformRow + 1, platformCol],
            matrix[platformRow + 1, platformCol + 1],
            matrix[platformRow + 1, platformCol + 2]);

        Console.WriteLine("{0} {1} {2}",
            matrix[platformRow + 2, platformCol],
            matrix[platformRow + 2, platformCol + 1],
            matrix[platformRow + 2, platformCol + 2]);           
    } 
}