//Write a method that reverses the digits of a given floating-point number.
using System;
using System.Linq;

    class ReverseNumber
    {
        static void Main()
        {
        double input = double.Parse(Console.ReadLine());
        double reversed = GetReversedNumber(input);
        Console.WriteLine(reversed);
        }

    static double GetReversedNumber(double num)
    {
        char[] charArr = num.ToString().ToCharArray();
        char[] revers = new char[charArr.Length];
        for (int i = charArr.Length-1, j=0; i >= 0&&j<revers.Length ; i--, j++)
        {
            revers[j] = charArr[i];
        }
        string reversedNumber = string.Join("", revers);
        double reversedDouble = double.Parse(reversedNumber);

        return reversedDouble;
    }
    }

