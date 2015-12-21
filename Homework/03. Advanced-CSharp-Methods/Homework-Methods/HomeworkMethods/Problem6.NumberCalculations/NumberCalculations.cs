using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCalculations
{
    class NumberCalculations
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double[] arrayOfNums = input.Split(' ').Select(double.Parse).ToArray();
            //decimal[] arrayOfNums = input.Split(' ').Select(decimal.Parse).ToArray();
            Console.WriteLine(Max(arrayOfNums));
            Console.WriteLine(Min(arrayOfNums));
            Console.WriteLine(Avg(arrayOfNums));
            Console.WriteLine(Sum(arrayOfNums));
            Console.WriteLine(Prod(arrayOfNums));
        }

        public static decimal Sum(decimal[] arr)
        {
            decimal sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.Write("Decimal Sum: ");
            return sum;
        }
        public static double Sum(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.Write("Double Sum: ");
            return sum;
        }
        public static decimal Prod(decimal[] arr)
        {
            decimal prod = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                prod *= arr[i];
            }
            Console.Write("Decimal Product: ");
            return prod;
        }
        public static double Prod(double[] arr)
        {
            double prod = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                prod *= arr[i];
            }
            Console.Write("Double Product: ");
            return prod;
        }

        public static decimal Avg(decimal[] arr)
        {
            decimal sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            decimal avg = sum / arr.Length;
            Console.Write("Decimal Average: ");
            return avg;
        }
        public static double Avg(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double avg = sum / arr.Length;
            Console.Write("Double Average: ");
            return avg;
        }
        public static decimal Min(decimal[] arr)
        {
            decimal min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.Write("Decimal Min: ");
            return min;
        }
        public static double Min(double[] arr)
        {
            double min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.Write("Double Min: ");
            return min;
        }
        public static decimal Max(decimal[] arr)
        {
            decimal max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.Write("Decimal Max: ");
            return max;
        }
        public static double Max(double[] arr)
        {
            double max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.Write("Double MAx: ");
            return max;
        }
    }
}
