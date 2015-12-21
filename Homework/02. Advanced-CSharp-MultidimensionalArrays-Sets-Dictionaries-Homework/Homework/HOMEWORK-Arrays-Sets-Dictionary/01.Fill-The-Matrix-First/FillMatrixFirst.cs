using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FillMatrixFirst
{
    static void Main()
    {
        Console.Write("Enter matrix height and length: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                int element = int.Parse(Console.ReadLine());
                matrix[row, col] = element;
            }
        }

        Console.WriteLine();
        Console.WriteLine("The matrix is as follows:");

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0} ", matrix[col, row]);
            }

            Console.WriteLine();
        }        
    }
}