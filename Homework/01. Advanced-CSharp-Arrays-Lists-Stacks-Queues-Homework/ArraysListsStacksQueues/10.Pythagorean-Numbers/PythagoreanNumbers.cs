//George likes math. Recently he discovered an interesting property of the Pythagorean Theorem: there are infinite number of triplets of integers a, b and c (a ≤ b), such that a2 + b2 = c2. Write a program to help George find all such triplets (called Pythagorean numbers) among a set of integer numbers.
using System;
using System.Collections.Generic;
using System.Linq;

class PythagoreanNumbers
{
    static void Main()
    {
        int countNumber = int.Parse(Console.ReadLine());
        int[] numbers = new int[countNumber];
        bool isNot = false;
        for (int i = 0; i < countNumber; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int a = 0; a < numbers.Length; a++)
        {
            for (int b = 0; b < numbers.Length; b++)
            {
                for (int c = 0; c < numbers.Length; c++)
                {
                    if (numbers[a] <= numbers[b] && (numbers[a] * numbers[a] + numbers[b] * numbers[b] == numbers[c] * numbers[c]))
                    {
                        Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", numbers[a], numbers[b], numbers[c]);
                        isNot = true;
                    }
                }
            }
        }
        if (!isNot)
        {
            Console.WriteLine("No");
        }
    }
}

