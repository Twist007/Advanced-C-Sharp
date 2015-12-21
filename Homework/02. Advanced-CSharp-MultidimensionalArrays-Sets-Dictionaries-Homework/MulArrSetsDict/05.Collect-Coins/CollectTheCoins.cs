//Working with multidimensional arrays can be (and should be) fun. Let's make a game out of it.You receive the layout of a board from the console.Assume it will always have 4 rows which you'll get as strings, each on a separate line. Each character in the strings will represent a cell on the board. Note that the strings may be of different length.You are the player and start at the top-left corner (that would be position [0, 0] on the board). On the fifth line of input you'll receive a string with movement commands which tell you where to go next, it will contain only these four characters – '>' (move right), '<' (move left), '^' (move up) and 'v' (move down).You need to keep track of two types of events – collecting coins(represented by the symbol '$', of course) and hitting the walls of the board(when the player tries to move off the board to invalid coordinates). When all moves are over, print the amount of money collected and the number of walls hit.

using System;
class CollectTheCoins
{
    static int rowCurent = 0;
    static int colCurent = 0;
    static int coins = 0;
    static int wallHits = 0;

    static void Main()
    {
        string[] layaout = new string[4];
        Inputs(layaout);
        string moves = Console.ReadLine();
        Moves(moves, layaout);

        Console.WriteLine("Coins collected: {0}", coins);
        Console.WriteLine("Walls hit: {0}", wallHits);
    }

    static void Inputs(string[] layout)
    {
        for (int i = 0; i < layout.Length; i++)
        {
            layout[i] = Console.ReadLine();
        }

    }

    static void CurentMove(string[] layout, int row, int col)
    {
        if (row >= 0 && row < layout.Length && col >= 0 && col < layout[row].Length)
        {
            rowCurent = row;
            colCurent = col;

            if (layout[rowCurent][colCurent] == '$')
            {
                coins++;
            }
        }
        else
        {
            wallHits++;
        }
    }

    static void Moves(string moves, string[] layout)
    {
        //[0,0] chek firs element
        if (layout[rowCurent][colCurent] == '$')
        {
            coins++;
        }

        foreach (var move in moves)
        {
            switch (move)
            {
                case '>':
                    CurentMove(layout, rowCurent, colCurent + 1);
                    break;
                case '<':
                    CurentMove(layout, rowCurent, colCurent - 1);
                    break;
                case '^':
                    CurentMove(layout, rowCurent - 1, colCurent);
                    break;
                case 'V':
                    CurentMove(layout, rowCurent + 1, colCurent);
                    break;
            }
        }
    }
}

