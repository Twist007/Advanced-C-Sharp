
using System;
using System.Collections.Generic;

class MeLabyrinthDash
{
    static void Main()
    {
        const string obstacleChrachters = "*#@";

        int numberOfRows = int.Parse(Console.ReadLine());

        char[][] matrix = new char[numberOfRows][];

        for (int i = 0; i < numberOfRows; i++)
        {
            string input = Console.ReadLine();
            matrix[i] = input.ToCharArray();
        }

        int livesLeft = 3;
        int row = 0;
        int col = 0;
        int movesMade = 0;

        //Point currentCell=new Point(row, col);// whit struct
        string commands = Console.ReadLine();

        foreach (var directions in commands)
        {
            int previousRow = row;
            int previousCol = col;

            switch (directions)
            {
                case '<':
                    col--;
                    break;
                case '>':
                    col++;
                    break;
                case '^':
                    row--;
                    break;
                case 'v':
                    row++;
                    break;
            }

            if (!IsCellInsideMatrix(row, col, matrix) || matrix[row][col] == ' ')
            {
                Console.WriteLine("Fell off a cliff! Game Over!");
                movesMade++;
                break;
            }
            if (matrix[row][col] == '_' || matrix[row][col] == '|')
            {
                Console.WriteLine("Bumped a wall.");
                row = previousRow;
                col = previousCol;
            }
            else if (obstacleChrachters.Contains(matrix[row][col].ToString()))
            {
                livesLeft--;
                movesMade++;
                Console.WriteLine("Ouch! That hurt! Lives left: {0}", livesLeft);

                if (livesLeft <= 0)
                {
                    Console.WriteLine("No lives left! Game Over!");
                    break;
                }
            }
            else if (matrix[row][col] == '$')
            {
                livesLeft++;
                movesMade++;
                matrix[row][col] = '.';
                Console.WriteLine("Awesome! Lives left: {0}", livesLeft);
            }
            else
            {
                movesMade++;
                Console.WriteLine("Made a move!");
            }
        }

        Console.WriteLine("Total moves made: {0}", movesMade);
    }

    private static bool IsCellInsideMatrix(int row, int col, char[][] matrix)
    {
        bool isRowInsideMatrix = 0 <= row && row < matrix.Length;

        if (!isRowInsideMatrix)
        {
            return false;
        }

        bool isColInRange = 0 <= col && col < matrix[row].Length;

        return isColInRange;
    }

    //public struct Point
    //{
    //    public Point(int x, int y)
    //        : this()
    //    {
    //        this.X = x;
    //        this.Y = y;
    //    }
    //    public int X { get; set; }
    //    public int Y { get; set; }
    //}
}

