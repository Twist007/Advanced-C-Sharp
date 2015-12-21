//Write a program to find all increasing sequences inside an array of integers. The integers are given on a single line, separated by a space. Print the sequences in the order of their appearance in the input array, each at a single line. Separate the sequence elements by a space. Find also the longest increasing sequence and print it at the last line. If several sequences have the same longest length, print the left-most of them. 
using System;
using System.Linq;
class LongestIncreasingSequence
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int count = 1;
        int end = 0;
        int temp = 1;

        Console.WriteLine();
        Console.Write(numbers[0] + " ");

        for (int i = 1; i < numbers.Length; i++)
        {

            if (numbers[i] > numbers[i - 1])
            {
                Console.Write(numbers[i] + " ");
                temp++;
            }
            else
            {
                Console.WriteLine();
                Console.Write(numbers[i] + " ");
                temp = 1;
            }

            if (temp > count)
            {
                count = temp;
                end = i;
            }
        }

        Console.WriteLine();
        Console.Write("Longest: ");

        int start = end - count+1;
        for (int i = start; i <= end; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}

