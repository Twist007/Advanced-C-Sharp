using System;
using System.Collections.Generic;

internal class XRemoval
{
    private static void Main()
    {
        List<char[]> inputMatrix = new List<char[]>();
        var outputMatrix = new List<char[]>();

        var line = Console.ReadLine();
        while (line != "END")
        {
            outputMatrix.Add(line.ToCharArray());

            var lowerCase = line.ToLower().ToCharArray();
            inputMatrix.Add(lowerCase);

            line = Console.ReadLine();
        }

        for (int row = 0; row < inputMatrix.Count - 2; row++)
        {
            var maxColLength = Math.Min(inputMatrix[row].Length - 2,
                Math.Min(inputMatrix[row + 1].Length - 1, inputMatrix[row + 2].Length - 2));
            for (int col = 0; col < maxColLength; col++)
            {
                var first = inputMatrix[row][col];
                var second = inputMatrix[row][col + 2];
                var third = inputMatrix[row + 1][col + 1];
                var fourht = inputMatrix[row + 2][col];
                var fifth = inputMatrix[row + 2][col + 2];

                if (first == second && second == third && third == fourht && fourht == fifth)
                {
                    outputMatrix[row][col] = '\0'; //empty char
                    outputMatrix[row][col + 2] = '\0';
                    outputMatrix[row + 1][col + 1] = '\0';
                    outputMatrix[row + 2][col] = '\0';
                    outputMatrix[row + 2][col + 2] = '\0';
                }
            }
        }
        foreach (var result in outputMatrix)
        {
            foreach (var ch in result)
            {
                if (ch != '\0')
                {
                    Console.Write(ch);
                }
            }
            Console.WriteLine();
        }
    }
}

