using System;
using System.Numerics;

namespace _06NumberCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            string[] results = {"minimum", "maximum", "average", "sum", "product"};
            double dRes;
            int iRes;
            decimal mRes;
            bool isInt = true;
            bool isDbl = true;
            bool isDec = true;
            bool isValid = true;
            int[] ints = new int[nums.Length];
            decimal[] decs = new decimal[nums.Length];
            double[] dbles = new double[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (!int.TryParse(nums[i], out iRes))
                {
                    isInt = false;
                    break;
                }
                ints[i] = iRes;
            }

            if (!isInt)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (!decimal.TryParse(nums[i], out mRes))
                    {
                        isDec = false;
                        break;
                    }
                    decs[i] = mRes;
                }
            }

            if (!isDec)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (!double.TryParse(nums[i], out dRes))
                    {
                        isDbl = false;
                        isValid = false;
                        break;
                    }
                    dbles[i] = dRes;
                }
            }

            if (!isValid)
            {
                Console.WriteLine("Cannot work with these numbers sorry ...");
            }
            else if (isInt)
            {               
                string[] calculatedInts = CalculateNumbers(ints);
                for (int i = 0; i < calculatedInts.Length; i++)
                {
                    Console.WriteLine("{0} = {1}", results[i], calculatedInts[i]);
                }
            }
            else if (isDec)
            {
                string[] calculatedDecs = CalculateNumbers(decs);
                for (int i = 0; i < calculatedDecs.Length; i++)
                {
                    Console.WriteLine("{0} = {1}", results[i], calculatedDecs[i]);
                }
            }

            else
            {
                string[] calculatedDbles = CalculateNumbers(dbles);
                for (int i = 0; i < calculatedDbles.Length; i++)
                {
                    Console.WriteLine("{0} = {1}", results[i], calculatedDbles[i]);
                }
            }
        }

        static string[] CalculateNumbers(decimal[] arr)
        {
            string[] res = new string[5];
            decimal min = decimal.MaxValue;
            decimal max = decimal.MinValue;
            decimal sum = 0;
            decimal prod = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                sum += arr[i];
                prod *= arr[i];
            }
            decimal avg = sum / 5;
            res[0] = min.ToString();
            res[1] = max.ToString();
            res[2] = avg.ToString();
            res[3] = sum.ToString();
            res[4] = prod.ToString();
            return res;
        }

        static string[] CalculateNumbers(int[] arr)
        {
            string[] res = new string[5];
            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;
            BigInteger prod = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                sum += arr[i];
                prod *= arr[i];
            }
            int avg = sum / 5;
            res[0] = min.ToString();
            res[1] = max.ToString();
            res[2] = avg.ToString();
            res[3] = sum.ToString();
            res[4] = prod.ToString();
            return res;
        }

        static string[] CalculateNumbers(double[] arr)
        {
            string[] res = new string[5];
            double min = int.MaxValue;
            double max = int.MinValue;
            double sum = 0;
            double prod = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                sum += arr[i];
                prod *= arr[i];
            }
            double avg = sum / 5;
            res[0] = min.ToString();
            res[1] = max.ToString();
            res[2] = avg.ToString();
            res[3] = sum.ToString();
            res[4] = prod.ToString();
            return res;
        }
    }
}
