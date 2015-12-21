using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NumberCalculations
{
    class NumberCalculations
    {
        static void Main(string[] args)
        {
            List<double> doubleList = new List<double> { 2.11, 2.75 , 7.55, 4.33};
            List<decimal> decimalList = new List<decimal> { 2.55633455M, 3.423432542M, 5.13123445M, 112.23434M };

            CalculatingList(doubleList);
            CalculatingList(decimalList);

        }

        static void CalculatingList(List<double> List)
        {
            double min = List.Min();
            double max = List.Max();
            double sum = List.Sum();
            double avg = List.Average();
            Console.Write("Min = {0}, Max = {1}, Sum = {2}, Average = {3}", min, max, sum, avg);
            Console.WriteLine();
        }
        static void CalculatingList(List<decimal> List)
        {
            decimal min = List.Min();
            decimal max = List.Max();
            decimal sum = List.Sum();
            decimal avg = List.Average();
            Console.Write("Min = {0}, Max = {1}, Sum = {2}, Average = {3}", min, max, sum, avg);
            Console.WriteLine();
        }

    }
}
