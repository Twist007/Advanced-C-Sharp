namespace _05.MultiplyIntegersInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    class MultiplyIntegersInArray
    {
        static Stack<BigInteger> resultArr = new Stack<BigInteger>(); 

        static void Main()
        {
            Console.Write("Insert series of integers separataed by space or comma = ");
            int[] nums = Console.ReadLine()
                .Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] arr = new int[nums.Length - 1];
            GenerateCombinations(arr, nums, nums.Length, 0);

            Console.WriteLine(string.Join(" ", resultArr));
        }

        static void GenerateCombinations(int[] arr, int[] nums, int sizeOfSet, int index, int start = 0)
        {
            if (index == arr.Length)
            {
                AddToResults(arr, nums);
            }
            else
            {
                for (int i = start; i < sizeOfSet; i++)
                {
                    arr[index] = i;
                    GenerateCombinations(arr, nums, sizeOfSet, index + 1, i + 1);
                }
            }
        }

        static void AddToResults(int[] arr, int[] nums)
        {
            BigInteger res = 1;
            foreach (var i in arr)
            {
                res *= nums[i];
            }

            resultArr.Push(res);
        }
    }
}
