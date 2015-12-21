//Write methods to calculate the minimum, maximum, average, sum and product of a given set of numbers. Overload the methods to work with numbers of type double and decimal.
//----->Note: Do not use LINQ.<-----

using System;
using System.Linq;
    class NumberCalculations
    {
        static void Main()
        {
        
        //Linq only for input -> Select()
        Console.WriteLine("double numbers");
        double[] doubles = Console.ReadLine().Split().Select(double.Parse).ToArray();
        Console.WriteLine("Min: {0}, Max: {1}, Sum: {2}, Average: {3}, Product: {4}",
            GetMin(doubles),
            GetMax(doubles),
            GetSum(doubles),
            GetAverage(doubles),
            GetProduct(doubles));

        Console.WriteLine("decimal numbers");
        decimal[] decimals = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
        Console.WriteLine("Min: {0}, Max: {1}, Sum: {2}, Average: {3}, Product: {4}",
            GetMin(decimals),
            GetMax(decimals),
            GetSum(decimals),
            GetAverage(decimals),
            GetProduct(decimals));
    }
    static double GetMin(double[] arr)
    {
        double minNumber = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (minNumber>arr[i])
            {
                minNumber = arr[i];
            }
        }
        return minNumber;
    }
    static decimal GetMin(decimal[] arr)
    {
        decimal minNumber = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (minNumber > arr[i])
            {
                minNumber = arr[i];
            }
        }
        return minNumber;
    }

    static double GetMax(double[] arr)
    {
        double maxNumber = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (maxNumber<arr[i])
            {
                maxNumber = arr[i];
            }
        }

        return maxNumber;
    }
    static decimal GetMax(decimal[] arr)
    {
        decimal maxNumber = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (maxNumber < arr[i])
            {
                maxNumber = arr[i];
            }
        }

        return maxNumber;
    }

    static double GetSum(double[] arr)
    {
        double sum = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return sum;
    }
    static decimal GetSum(decimal[] arr)
    {
        decimal sum = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return sum;
    }

    static double GetProduct(double[] arr)
    {
        double product = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            product *= arr[i];
        }

        return product;
    }
    static decimal GetProduct(decimal[] arr)
    {
        decimal product = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            product *= arr[i];
        }

        return product;
    }

    static double GetAverage(double[] arr)
    {
        double sumAvg = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            sumAvg += arr[i];
        }
        sumAvg = sumAvg / arr.Length;

        return sumAvg;
    }
    static decimal GetAverage(decimal[] arr)
    {
        decimal sumAvg = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            sumAvg += arr[i];
        }
        sumAvg = sumAvg / arr.Length;

        return sumAvg;
    }

}

