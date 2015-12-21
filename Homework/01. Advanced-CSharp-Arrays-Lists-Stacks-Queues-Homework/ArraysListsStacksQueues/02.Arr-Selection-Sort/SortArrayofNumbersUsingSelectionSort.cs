//Selection Sort
//Write a program to sort an array of numbers and then print them back on the console. The numbers should be entered from the console on a single line, separated by a space. Refer to the examples for problem 1.
//Note: Do not use the built-in sorting method, you should write your own. Use the selection sort algorithm. 
//Hint: To understand the sorting process better you may use a visual aid, e.g. Visualgo.


using System;
using System.Linq;

class SortArrayofNumbersUsingSelectionSort
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int minNumber = int.MinValue;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            minNumber = i;

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[minNumber])
                {
                    minNumber = j;
                }
            }

            if (minNumber != i)
            {
                int temp = numbers[i];
                numbers[i] = numbers[minNumber];
                numbers[minNumber] = temp;
            }

        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

