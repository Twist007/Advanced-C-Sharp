using System;
using System.Collections.Generic;
using System.Linq;

class RadioactiveBunnies
{
    static void Main()
    {
        var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = dimensions[0];
        int columns = dimensions[1];
        //char[,]matrix=new char[rows, columns];

        char[][] charMatrix = new char[rows][];
        for (int rowFill = 0; rowFill < rows; rowFill++)
        {
            string inputLine = Console.ReadLine();
            charMatrix[rowFill] = inputLine.ToCharArray();
        }

        string commands = Console.ReadLine();
        int playerStartRow = 0;
        int playerStartCol = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (charMatrix[i][j] == 'P')
                {
                     playerStartRow = i;
                     playerStartCol = j;
                }
            }
        }
      

        foreach (var direction in commands)
        {
            int previousRow =playerStartRow ;
            int previousCol = playerStartCol;
            switch (direction)
            {
                case 'L':
                    playerStartCol--;
                    break;
                case 'R':
                    playerStartCol++;
                    break;
                case 'U':
                    playerStartRow--;
                    break;
                case 'D':
                    playerStartRow++;
                    break;
            }


        }
    }
}

