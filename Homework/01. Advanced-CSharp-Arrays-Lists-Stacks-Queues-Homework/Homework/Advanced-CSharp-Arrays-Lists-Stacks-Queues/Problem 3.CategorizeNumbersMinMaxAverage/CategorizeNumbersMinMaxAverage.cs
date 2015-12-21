using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Globalization;

    internal class CategorizeNumbersMinMaxAverage
    {
      static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            List<double> roundNum = new List<double>();
            List<double> floatNum = new List<double>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%1 != 0)
                {
                    floatNum.Add(numbers[i]);
                }
                else
                {
                    roundNum.Add(numbers[i]);
                }
            }
            Console.WriteLine();
            Console.Write("Float Numbers: ");
            floatNum.ForEach(a => Console.Write(a + " "));
            Console.WriteLine();
            Console.WriteLine("\nmin => {0}\nmax => {1}\nsum => {2}\naverage -> {3:f2}\n", floatNum.Min(), floatNum.Max(), floatNum.Sum(),floatNum.Average());
            Console.Write("Round Numbers: ");
            roundNum.ForEach(b => Console.Write(b + " "));
            Console.WriteLine();
            Console.WriteLine("\nmin => {0}\nmax => {1}\nsum => {2}\naverage -> {3:f2}\n", roundNum.Min(), roundNum.Max(), roundNum.Sum(), roundNum.Average());
           }
    }
