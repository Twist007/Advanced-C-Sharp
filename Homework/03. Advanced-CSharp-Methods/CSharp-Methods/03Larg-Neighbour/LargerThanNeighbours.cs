//Write a method that checks if the element at given position in a given array of integers is larger than its two neighbours (when such exist).
using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThenNeighbours(numbers, i));
        }

    }

    static bool IsLargerThenNeighbours(int[] numbers, int i)
    {
         if (i - 1 >= 0 && i + 1 < numbers.Length)
        {
            if (numbers[i] > numbers[i-1] && numbers[i] > numbers[i + 1])
            {
                return true;
            }
        }
        else if (i - 1 >= 0)
        {
            if (numbers[i] > numbers[i-1])
            {
                return true;
            }
        }
        else if (i + 1 < numbers.Length)
        {
            if (numbers[i] > numbers[i+1])
            {
                return true;
            }
        }

        return false;
    }
}

