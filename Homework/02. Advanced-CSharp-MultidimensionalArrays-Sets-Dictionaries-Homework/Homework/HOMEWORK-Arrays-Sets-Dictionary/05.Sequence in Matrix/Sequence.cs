using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Sequence
{
    static void Main()
    {
        Console.Write("Enter sizes seperated by space: ");
        var sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = sizes[0];
        int cols = sizes[1];
        string[,] matrix = new string[rows, cols];

        for(int row = 0; row < rows; row++)
        {
            string[] container = Console.ReadLine().Split();
            for(int col = 0; col < cols; col++)
            {
                matrix[row, col] = container[col];
            }
        }
        int firstLength = 1;
        int secondLength = 0;
        int thirdLength = 1;
        string mostCommonString = string.Empty;

        for(int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols - 1; col++) 
            {
                if(matrix[row, col].Equals(matrix[row, col + 1]))
                {
                    firstLength++;
                    mostCommonString = matrix[row, col];
                }
            }
        }

        for(int row = 0; row < rows - 1; row++)
        {
            for(int col = 0; col < cols; col++)
            {
                if(matrix[row, col].Equals(matrix[row + 1, col]))
                {
                    secondLength++;
                    mostCommonString = matrix[row, col];
                }
            }
        }

        for(int row = 0; row < rows - 1; row++)
        {
            for(int col = 0; col < cols - 1; col++)
            {
                if(matrix[row, col].Equals(matrix[row + 1, col + 1]))
                {
                    thirdLength++;
                    mostCommonString = matrix[row, col];
                }
            }
        }

        int maxLength = Math.Max(firstLength, secondLength);
        if(thirdLength >= maxLength)
        {
            maxLength = thirdLength;
        }

        Console.Write(mostCommonString);
        for(int i = 1; i < maxLength; i++)
        {
            Console.Write(", {0}", mostCommonString);
        }
        Console.WriteLine();
    }
}
