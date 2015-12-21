
using System;
using System.Linq;

class BunkerBuster
{
    static void Main()
    {
        var arrField = Console.ReadLine().Split().Select(int.Parse).ToArray();
       int rows = arrField[0];
        int columns = arrField[1];
        int[,] field = new int[rows, columns];
        for (int row = 0; row < rows; row++)
        {
            int[] rowInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int col = 0; col < columns; col++)
            {
                field[row, col] = rowInput[col];
            }
        }

        string command = Console.ReadLine();
        while (command != "cease fire!")
        {
            var bombs = command.Split();

            int fieldRow = int.Parse(bombs[0]);
            int fieldCol = int.Parse(bombs[1]);
            int bombPower = char.Parse(bombs[2]);

            int minRow = Math.Max(0, fieldRow - 1);
            int maxRow = Math.Min(rows-1, fieldRow + 1);
            int minCol = Math.Max(0, fieldCol - 1);
            int maxCol = Math.Min(columns-1, fieldCol + 1);
            int halfPower = (int)Math.Ceiling(bombPower / 2.0);
            for (int row = minRow; row <= maxRow; row++)
            {
                for (int col = minCol; col <= maxCol; col++)
                {
                    if (row == fieldRow && col == fieldCol)
                    {
                        field[row, col] -= bombPower;
                    }
                    else
                    {
                        field[row, col] -= halfPower;
                    }
                }
            }

            command = Console.ReadLine();

        }
        int destroyed = CauntDestroy(field);
        double purcentDamage = DamageInParcent(destroyed, rows, columns);

        Console.WriteLine("Destroyed bunkers: {0}", destroyed);
        Console.WriteLine("Damage done: {0:f1} %", purcentDamage);
    }

    private static double DamageInParcent(int damage, int rows, int cols)
    {
        double purcent = (damage*100)/(double)(rows*cols);
        return purcent;
    }

    private static int CauntDestroy(int[,] matrix)
    {
        int counter = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i,j]<=0)
                {
                    counter++;
                }
            }
        }

        return counter;
    }
}

