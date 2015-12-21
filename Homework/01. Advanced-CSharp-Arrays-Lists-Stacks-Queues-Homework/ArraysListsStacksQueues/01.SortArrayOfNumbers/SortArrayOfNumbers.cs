//Write a program to read an array of numbers from the console, sort them and print them back on the console. The numbers should be entered from the console on a single line, separated by a space. 

using System;
using System.Collections.Generic;
using System.Linq;

class SortArrayOfNumbers
{
    static void Main()
    {
        int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Array.Sort(inputNumbers);

        Console.WriteLine(string.Join(" ", inputNumbers));

    }
}

