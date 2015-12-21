//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. 
using System;
using System.Collections.Generic;
using System.Linq;

class SequenceInMatrix
{
    static void Main()
    {

        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        string[,] matrix = new string[rows, columns];

        for (int row = 0; row < rows; row++)
        {
            string[] filRow = Console.ReadLine().Split();
            for (int col = 0; col < columns; col++)
            {
                matrix[row, col] = filRow[col];
            }
        }

        int maxSeq = 0;
        int countMax = 0;
        string longestSeq = matrix[0, 0];
        // row
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns-1; col++)
            {
                if (matrix[row,col]==matrix[row, col+1])
                {
                    maxSeq++;
                }
                else
                {
                    maxSeq = 1;
                }

                if (maxSeq>countMax)
                {
                    longestSeq = matrix[row, col];
                    countMax = maxSeq;
                }

            }

            maxSeq = 1;

        }

        //col
        for (int col = 0; col < columns; col++)
        {
            for (int row = 0; row < rows-1; row++)
            {
                if (matrix[row,col]==matrix[row+1,col])
                {
                    maxSeq++;
                }
                else
                {
                    maxSeq = 1;
                }

                if (maxSeq>countMax)
                {
                    longestSeq = matrix[row, col];
                    countMax = maxSeq;
                }
            }

            maxSeq = 1;

        }
        //diagonal
        for (int r = 0, c = 0; r < rows - 1 && c < columns - 1; r++, c++)
        {
            if (matrix[r, c] == matrix[r + 1, c + 1])
            {
                maxSeq++;
            }
            else
            {
                maxSeq = 1;
            }

            if (maxSeq > countMax)
            {
                longestSeq = matrix[r, c];
                countMax = maxSeq;
            }
        }

            maxSeq = 1;

        
        
        Console.WriteLine();
        for (int i = 0; i < countMax; i++)
        {
            Console.Write("{0}, ", longestSeq);
        }
        Console.WriteLine();
    }
}

