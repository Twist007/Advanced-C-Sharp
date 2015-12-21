using System;
class CollectTheCoins
{
    static void Main()
    {
        char[][] board = new char[4][];
        for (int i = 0; i < 4; i++)
        {
            string inputLine = Console.ReadLine();
            board[i] = new char[inputLine.Length];
            for (int j = 0; j < inputLine.Length; j++)
            {
                board[i][j] = inputLine[j];
            }
        }

        string commands = Console.ReadLine();
        int rowIndex = 0;
        int colIndex = 0;
        int coins = 0;
        int walls = 0;

        for (int i = 0; i < commands.Length; i++)
        {
            if (commands[i] == 'V')
            {
                if ((rowIndex + 1) == board.Length || board[rowIndex + 1].Length < colIndex + 1)
                {
                    walls++;
                }
                else if (board[rowIndex + 1][colIndex] == '$')
                {
                    coins++;
                    rowIndex++;
                }
                else
                {
                    rowIndex++;
                }

            }
            else if (commands[i] == '^')
            {
                if ((rowIndex - 1) < 0 || board[rowIndex - 1].Length < colIndex + 1)
                {
                    walls++;
                }
                else if (board[rowIndex - 1][colIndex] == '$')
                {
                    coins++;
                    rowIndex--;
                }
                else
                {
                    rowIndex--;
                }
            }
            else if (commands[i] == '>')
            {
                if (colIndex + 1 > board[rowIndex].Length)
                {
                    walls++;
                }
                else if (board[rowIndex][colIndex + 1] == '$')
                {
                    coins++;
                    colIndex++;
                }
                else
                {
                    colIndex++;
                }

            }
            else if (commands[i] == '<')
            {
                if ((colIndex - 1) <= 0)
                {
                    walls++;
                }
                else if (board[rowIndex][colIndex - 1] == '$')
                {
                    coins++;
                    colIndex--;
                }
                else
                {
                    colIndex--;
                }

            }
        }

        Console.WriteLine("Coins collected: {0}", coins);
        Console.WriteLine("Walls hit: {0}", walls);
    }
}

