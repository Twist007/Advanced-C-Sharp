//Write a program which reads a string matrix from the console and performs certain operations with its elements. User input is provided in a similar way like in the problem above – first you read the dimensions and then the data. Remember, you are not required to do this step first, you may add this functionality later.Your program should then receive commands in format: "swap row1 col1 row2c col2" where row1, row2, col1, col2 are coordinates in the matrix. In order for a command to be valid, it should start with the "swap" keyword along with four valid coordinates (no more, no less). You should swap the values at the given coordinates (cell [row1, col1] with cell [row2, col2]) and print the matrix at each step (thus you'll be able to check if the operation was performed correctly). If the command is not valid (doesn't contain the keyword "swap", has fewer or more coordinates entered or the given coordinates do not exist), print "Invalid input!" and move on to the next command. Your program should finish when the string "END" is entered. 

using System;
using System.Collections.Generic;

class MatrixShuffling
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        List<string> data = new List<string>();

        for (int i = 0; i < rows * columns; i++)
        {
            string input = Console.ReadLine();
            data.Add(input);
        }

        string[,] matrix = new string[rows, columns];
        int dataCount = 0;
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                matrix[row, col] = data[dataCount];
                dataCount++;
            }
        }

        // Print(matrix);

        string[] command = Console.ReadLine().Split();

        while (command[0] != "END")
        {
            if (command.Length == 5 && command[0] == "swap")
            {

                int x1 = int.Parse(command[1]);
                int y1 = int.Parse(command[2]);
                int x2 = int.Parse(command[3]);
                int y2 = int.Parse(command[4]);

                if (x1 >= 0 && x1 <= rows && x2 >= 0 && x2 <= rows && y1 >= 0 && y1 <= columns && y2 >= 0 && y2 <= columns)
                {
                    string newMatrix = matrix[x1, y1];
                    matrix[x1, y1] = matrix[x2, y2];
                    matrix[x2, y2] = newMatrix;

                    Print(matrix);

                }
                else
                {

                    Console.WriteLine("Invalid input");
                }
            }
            else
            {

                Console.WriteLine("Invalid input");
            }

            command = Console.ReadLine().Split();
        }
    }

    static void Print(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(" " + matrix[row, col]);
            }
            Console.WriteLine();
        }

    }
}

