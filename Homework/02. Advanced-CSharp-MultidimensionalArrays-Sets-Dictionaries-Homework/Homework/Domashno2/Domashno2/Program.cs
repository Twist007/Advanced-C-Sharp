using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillMatrix_1
{
    class FillMatrix_1
    {
        static int n = 0;

        static void MatrixPatternA()
        {
            int[,] MatrixA = new int[n, n];
            int count =1;
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    MatrixA[row,col]=count;
                    count++;
                }
            }
            PrintMatrix(MatrixA);
        }
        static void MatrixPatternB()
        {
            int[,] matrixB = new int[n, n];
            int count = 1;
            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrixB[row, col] = count;
                        count++;
                    }
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        matrixB[row, col] = count;
                        count++;
                    }
                }
            }
            PrintMatrix(matrixB);
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int a = 0; a < matrix.GetLength(0); a++)
            {
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    Console.Write("{0,1}", matrix[a, b]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            MatrixPatternA();
            Console.WriteLine();
            MatrixPatternB();
        }
    }
}