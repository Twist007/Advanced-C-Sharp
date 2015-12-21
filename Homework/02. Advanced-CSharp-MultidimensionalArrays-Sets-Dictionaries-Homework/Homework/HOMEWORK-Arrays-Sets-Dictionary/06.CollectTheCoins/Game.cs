using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Game
{
    static void Main()
    {
        string[] board = new string[4];
        for(int row = 0; row < board.GetLength(0); row++)
        {
            board[row] = Console.ReadLine();
        }
        int currentRow = 0;
        int currentCol = 0;
        int coins = 0;
        int wallHits = 0;

        string commands = Console.ReadLine();
        foreach (char currentDirection in commands)
        {
            if (currentDirection == 'V')
            {
                currentRow++;
                if (currentRow >= board.GetLength(0))
                {
                    currentRow--;
                    wallHits++;
                    continue;
                }
                else if (currentCol >= board[currentRow].Length)
                {
                    currentRow--;
                    wallHits++;
                    continue;
                }
            }
            else if (currentDirection == '>')
            {
                currentCol++;
                if (currentCol >= board[currentRow].Length)
                {
                    currentCol--;
                    wallHits++;
                    continue;
                }
            }
            else if (currentDirection == '<')
            {
                currentCol--;
                if (currentCol < 0)
                {
                    currentCol++;
                    wallHits++;
                    continue;
                }
            }
            else if (currentDirection == '^')
            {
                currentRow--;
                if (currentRow < 0)
                {
                    currentRow++;
                    wallHits++;
                    continue;
                }
                else if (currentCol >= board[currentRow].Length)
                {
                    currentRow++;
                    wallHits++;
                    continue;
                }
            }

            if (board[currentRow][currentCol].Equals('$'))
            {
                coins++;
            }
        }
        Console.WriteLine("Coins collected: {0}", coins);
        Console.WriteLine("Walls hit: {0}", wallHits);
    }
}
