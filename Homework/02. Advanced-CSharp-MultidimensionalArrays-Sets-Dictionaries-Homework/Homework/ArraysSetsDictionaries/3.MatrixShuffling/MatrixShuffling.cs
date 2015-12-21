using System;
class MatrixShuffling
{
    static void Main()
    {
        Console.WriteLine("Matrix shuffling.");
        Console.Write("rows= ");
        int matrixRows = int.Parse(Console.ReadLine());
        Console.Write("cols= ");
        int matrixCols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[matrixRows, matrixCols];
        Console.WriteLine("Enter the matrix: ");

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string line = Console.ReadLine();
            string[] lineAsArr = line.Split(' ');
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = lineAsArr[col];
            }
        }

        string command = Console.ReadLine();
        while (command != "END")
        {
            string[] commandAsArr = command.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            int number;
            bool commandValidity = commandAsArr[0] == "swap" && int.TryParse(commandAsArr[1], out number) && int.TryParse(commandAsArr[2], out number) &&
                                    int.TryParse(commandAsArr[3], out number) && int.TryParse(commandAsArr[4], out number) && commandAsArr.Length == 5;

            if (commandValidity == true)
            {
                int x1 = int.Parse(commandAsArr[1]);
                int y1 = int.Parse(commandAsArr[2]);
                int x2 = int.Parse(commandAsArr[3]);
                int y2 = int.Parse(commandAsArr[4]);

                string holder = matrix[x1, y1];
                matrix[x1, y1] = matrix[x2, y2];
                matrix[x2, y2] = holder;

                PrintMatrix(matrix);

            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            command = Console.ReadLine();
        }

    }

    static void PrintMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row,col] + " ");
            }
            Console.WriteLine();
        }
    }
}

