//Write a program that reads N floating-point numbers from the console. Your task is to separate them in two sets, one containing only the round numbers (e.g. 1, 1.00, etc.) and the other containing the floating-point numbers with non-zero fraction. Print both arrays along with their minimum, maximum, sum and average (rounded to two decimal places). 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Globalization;
class CategorizeNumbersAndFindMinMaxAverage
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        List<double> floatArr = new List<double>();

        List<int> arr = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 1 == 0)
            {
                arr.Add((int)numbers[i]);
            }
            else
            {
                floatArr.Add(numbers[i]);
            }
        }

        arr.Sort();

        floatArr.Sort();

        Console.WriteLine();

        Console.WriteLine("[{0}] -> min: {1:}, max: {2:}, sum: {3:}, avg: {4:f2}",
            string.Join(", ", floatArr),
            floatArr.Min(),
            floatArr.Max(),
            floatArr.Sum(),
            floatArr.Average());

        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:f2}",
            string.Join(", ", arr),
            arr.Min(),
            arr.Max(),
            arr.Sum(),
            arr.Average());
    }
}

