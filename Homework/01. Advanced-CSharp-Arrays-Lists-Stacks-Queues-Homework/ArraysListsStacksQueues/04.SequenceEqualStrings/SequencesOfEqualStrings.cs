//Write a program that reads an array of strings and finds in it all sequences of equal elements (comparison should be case-sensitive). The input strings are given as a single line, separated by a space. 
using System;
class SequencesOfEqualStrings
{
    static void Main()
    {
        string[] inputValue = Console.ReadLine().Split();

        Console.Write(inputValue[0] + " ");
        for (int i = 1; i < inputValue.Length; i++)
        {
            if (inputValue[i] == inputValue[i - 1])
            {
                Console.Write(inputValue[i] + " ");
            }
            else
            {
                Console.WriteLine();
                Console.Write(inputValue[i] + " ");
            }
        }
        Console.WriteLine();
    }
}

