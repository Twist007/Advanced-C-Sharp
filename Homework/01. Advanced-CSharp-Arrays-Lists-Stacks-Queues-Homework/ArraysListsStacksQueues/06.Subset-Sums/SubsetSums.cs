////Write a program that reads from the console a number N and an array of integers given on a single line. Your task is to find all subsets within the array which have a sum equal to N and print them on the console (the order of printing is not important). Find only the unique subsets by filtering out repeating numbers first. In case there aren't any subsets with the desired sum, print "No matching subsets."

using System;
using System.Collections.Generic;
using System.Linq;

class SubsetSums
{
    static void Main()
    {
        int nNumber = int.Parse(Console.ReadLine());
        int[] arrNumbers = Console.ReadLine().Split().Select(int.Parse).Distinct().ToArray();
        Console.WriteLine();

        bool isEqual=false;
        List<int> subset = new List<int>();

        double combinations = Math.Pow(2, arrNumbers.Length);

        for (int i = 1; i < combinations; i++)
        {
            int sum = 0;
            for (int j = 0; j < arrNumbers.Length; j++)
            {
                int mask = i & (1 << j);

                if (mask != 0)
                {
                    sum += arrNumbers[0 + j];
                    subset.Add(arrNumbers[0 + j]);
                }
            }

            if (sum == nNumber)
            {
                Console.WriteLine(string.Join(" + ", subset) + " = " + sum);
                isEqual = true;
            }
            subset.Clear();
        }

        if (!isEqual)
        {
            Console.WriteLine("No matching subsets.");
        }
    }
}


