
using System;
using System.Collections.Generic;
using System.Security;

class ClearingCommands
{
    const string CommandSymbols = "<>v^";

    private static void Main()
    {

        List<char[]> matrix = new List<char[]>();

        FillMatrix(matrix);

        for (int row = 0; row < matrix.Count; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                int currentRow = row;
                int currentCol = col;

                switch (matrix[row][col])
                {
                    case '<':
                        currentRow = row;
                        currentCol = col - 1;

                        while (currentCol >= 0 && !CommandSymbols.Contains(matrix[currentRow][currentCol].ToString()))
                        {
                            matrix[currentRow][currentCol] = ' ';
                            currentCol--;
                        }
                        //ClearCells(matrix, row, col - 1, 0, -1);
                        break;
                    case '>':
                        currentRow = row;
                        currentCol = col + 1;

                        while (currentCol < matrix[currentRow].Length && !CommandSymbols.Contains(matrix[currentRow][currentCol].ToString()))
                        {
                            matrix[currentRow][currentCol] = ' ';
                            currentCol++;
                        }
                        //ClearCells(matrix, row, col + 1, 0, 1);
                        break;
                    case '^':
                        currentRow = row - 1;
                        currentCol = col;

                        while (currentRow >= 0 && !CommandSymbols.Contains(matrix[currentRow][currentCol].ToString()))
                        {
                            matrix[currentRow][currentCol] = ' ';
                            currentRow--;
                        }
                        // ClearCells(matrix, row - 1, col, -1, 0);
                        break;
                    case 'v':
                        currentRow = row + 1;
                        currentCol = col;

                        while (currentRow < matrix.Count && !CommandSymbols.Contains(matrix[currentRow][currentCol].ToString()))
                        {
                            matrix[currentRow][currentCol] = ' ';
                            currentRow++;
                        }
                        // ClearCells(matrix, row + 1, col, 1, 0);
                        break;
                }
            }
        }

        PrintMatrix(matrix);
    }

    private static void FillMatrix(List<char[]> matrix)
    {
        string line = Console.ReadLine();
        while (line != "END")
        {
            matrix.Add(line.ToCharArray());

            line = Console.ReadLine();
        }
    }

    public static void PrintMatrix(List<char[]> matrix)
    {
        for (int row = 0; row < matrix.Count; row++)
        {
            Console.WriteLine("<p>{0}</p>", SecurityElement.Escape(new string(matrix[row])));
        }
    }
    //// whit methods
    //private static void ClearCells(List<char[]> matrix, int row, int col, int rowUpdate, int colUpdate)
    //{
    //    while (ShouldContinueCleaning(row, col, matrix) && !CommandSymbols.Contains(matrix[row][col].ToString()))
    //    {
    //        matrix[row][col] = ' ';
    //        row += rowUpdate;
    //        col += colUpdate;
    //    }
    //}

    //private static bool ShouldContinueCleaning(int row, int col, List<char[]> matrix)
    //{
    //    bool isRowValid = 0 <= row && row < matrix.Count;
    //    if (!isRowValid)
    //    {
    //        return false;
    //    }
    //    bool isCollValid = 0 <= col && col < matrix[row].Length;
    //    return isCollValid;
    //}
}

