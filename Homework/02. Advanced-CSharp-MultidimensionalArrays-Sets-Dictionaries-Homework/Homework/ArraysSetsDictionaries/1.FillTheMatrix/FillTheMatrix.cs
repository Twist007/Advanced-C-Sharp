using System;
class FillTheMatrix
{
    static void Main()
    {
        Console.WriteLine("This prgoram print a matrix of size N x N.");
        Console.Write("N= ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Which pattern do you want to print?");
        Console.WriteLine("Press \"A\" for pattern A and \"B\" for pattern B.");
        char option = char.Parse(Console.ReadLine());
        if (option == 'A' || option == 'a')
        {
            PatternAMatrix(n);
        }
        else if (option == 'B' || option == 'b')
        {
            PatternBMatrix(n);
        }
        else
        {
            Console.WriteLine("Error");
        }
    }

    static void PatternAMatrix(int n)
    {
        int[,] matrix = new int[n, n];

        int filling = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = filling;
                filling++;
            }
        }
        PrintMatrix(matrix);
    }

    static void PatternBMatrix(int n)
    {
        int[,] matrix = new int[n, n];

        int filling = 1;

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (col % 2 == 0)
                {
                    matrix[row, col] = filling;
                }
                else
                {
                    matrix[matrix.GetLength(0) - 1 - row, col] = filling;                  
                }
                filling++;
            }
        }

        PrintMatrix(matrix);
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
