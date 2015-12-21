//Write a method GetMax() with two parameters that returns the larger of two integers. Write a program that reads 2 integers from the console and prints the largest of them using the method GetMax().
using System;
using System.Collections.Generic;
using System.Linq;

class BiggerNumber
{
    static void Main()
    {
        int firsNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int max = GetMax(firsNumber, secondNumber);
        Console.WriteLine(max);
    }

    static int GetMax(int firstNumber, int secondNumber)
    {
        int max = firstNumber;
        if (firstNumber<secondNumber)
        {
            max = secondNumber;
        }

        return max;
    }
}

