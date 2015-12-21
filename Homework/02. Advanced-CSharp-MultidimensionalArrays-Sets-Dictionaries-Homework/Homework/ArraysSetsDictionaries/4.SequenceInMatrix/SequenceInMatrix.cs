using System;
using System.Collections.Generic;
class SequenceInMatrix
{
    static void Main()
    {
        Console.Write("rows= ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("cols= ");
        int cols = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the matrix: ");
        string[,] matrix = new string[rows, cols];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string line = Console.ReadLine();
            string[] lineAsArr = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = lineAsArr[col];
            }
        }


        List<string> longestSequence = new List<string>();

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {

                if (row == (matrix.GetLength(0) - 1) && col == (matrix.GetLength(1) - 1))
                {
                    continue;
                }
                else if (row == (matrix.GetLength(0) - 1) && col == 0)
                {
                    if (longestSequence.Count < Line(matrix, row, col).Count)
                    {
                        longestSequence = Line(matrix, row, col);
                    }
                }
                else if (row == 0 && col == (matrix.GetLength(1) - 1))
                {
                    if (longestSequence.Count < Column(matrix, row, col).Count)
                    {
                        longestSequence = Column(matrix, row, col);
                    }
                    if (longestSequence.Count < LeftDiagonal(matrix, row, col).Count)
                    {
                        longestSequence = LeftDiagonal(matrix, row, col);
                    }
                }
                else if (row == 0 && col == 0)
                {
                    if (longestSequence.Count < RightDiagonal(matrix, row, col).Count)
                    {
                        longestSequence = RightDiagonal(matrix, row, col);
                    }
                    if (longestSequence.Count < Line(matrix, row, col).Count)
                    {
                        longestSequence = Line(matrix, row, col);
                    }
                }
                else
                {
                    if (longestSequence.Count < RightDiagonal(matrix, row, col).Count)
                    {
                        longestSequence = RightDiagonal(matrix, row, col);
                    }
                    if (longestSequence.Count < Line(matrix, row, col).Count)
                    {
                        longestSequence = Line(matrix, row, col);
                    }
                    if (longestSequence.Count < Column(matrix, row, col).Count)
                    {
                        longestSequence = Column(matrix, row, col);
                    }
                    if (longestSequence.Count < LeftDiagonal(matrix, row, col).Count)
                    {
                        longestSequence = LeftDiagonal(matrix, row, col);
                    }
                }
            }
        }

        Console.WriteLine(String.Join(" ", longestSequence));

    }

    static List<string> RightDiagonal(string[,] matrix, int rowIndex, int colIndex)
    {
        List<string> result = new List<string>();
        result.Add(matrix[rowIndex, colIndex]);
        for (int row = rowIndex + 1, col = colIndex + 1; row < matrix.GetLength(0); row++, col++)
        {
            if (col < matrix.GetLength(1) && matrix[rowIndex, colIndex] == matrix[row, col])
            {
                result.Add(matrix[row, col]);
            }
            else
            {
                break;
            }
        }

        return result;
    }

    static List<string> LeftDiagonal(string[,] matrix, int rowIndex, int colIndex)
    {
        List<string> result = new List<string>();
        result.Add(matrix[rowIndex, colIndex]);

        for (int row = rowIndex + 1, col = colIndex - 1; row < matrix.GetLength(0); row++, col--)
        {
            if (col >= 0 && matrix[rowIndex, colIndex] == matrix[row, col])
            {
                result.Add(matrix[row, col]);
            }
            else
            {
                break;
            }
        }

        return result;
    }

    static List<string> Line(string[,] matrix, int rowIndex, int colIndex)
    {
        List<string> result = new List<string>();
        result.Add(matrix[rowIndex, colIndex]);

        for (int col = colIndex + 1; col < matrix.GetLength(1); col++)
        {
            if (matrix[rowIndex, colIndex] == matrix[rowIndex, col])
            {
                result.Add(matrix[rowIndex, col]);
            }
            else
            {
                break;
            }
        }

        return result;
    }

    static List<string> Column(string[,] matrix, int rowIndex, int colIndex)
    {
        List<string> result = new List<string>();
        result.Add(matrix[rowIndex, colIndex]);

        for (int row = rowIndex + 1; row < matrix.GetLength(0); row++)
        {
            if (matrix[rowIndex, colIndex] == matrix[row, colIndex])
            {
                result.Add(matrix[row, colIndex]);
            }
            else
            {
                break;
            }
        }

        return result;
    }

}

