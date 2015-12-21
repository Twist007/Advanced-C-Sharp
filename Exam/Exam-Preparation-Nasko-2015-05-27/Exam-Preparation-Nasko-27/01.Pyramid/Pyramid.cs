using System;
using System.Collections.Generic;
using System.Linq;

internal class Pyramid
{
    private static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        List<int> sequance = new List<int>();
        int previouNumber = int.Parse(Console.ReadLine().Trim());
        sequance.Add(previouNumber);
        for (int i = 1; i < input; i++)
        {
            int[] lineNumbers = Console.ReadLine().Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int minNumber = int.MaxValue;
            bool foundNumber = false;

            for (int j = 0; j < lineNumbers.Length; j++)
            {
                int currentNumber = lineNumbers[j];
                if (currentNumber < minNumber && currentNumber > previouNumber)
                {
                    minNumber = currentNumber;
                    foundNumber = true;
                }
            }

            if (foundNumber)
            {
                sequance.Add(minNumber);
                previouNumber = minNumber;
            }
            else
            {
                previouNumber++;
            }
        }
        Console.WriteLine(string.Join(", ", sequance));
    }
}

