using System;
using System.Collections.Generic;
using System.Linq;
  class SieveOfEratosthenes
    {
        static void Main()
        {
        int inputNum = int.Parse(Console.ReadLine());

        int[] numbers = new int[inputNum];

        int p = 2;
        int[] mark = new int[inputNum];


        //for (int i = 0; i < inputNum; i++)
        //{
        //    numbers.Add(i);
        //}

        //for (int j = 2; j < inputNum; j++)
        //{
        //    mark.Add(numbers[j] * p);
        //}

        //for (int k = 3, r=0; k < inputNum; k++,r+=2)
        //{
        //    if (numbers.Exists( m => m == mark[k-3]))
        //    {
        //        //numbers.RemoveAt(k);
        //        numbers[k+3] = 1;
        //    }
        //}

        for (int i = 2; i < inputNum; i++)
        {
            numbers[i] = i;
            mark[i] = i * p;
        }

        for (int j = 2; j < inputNum; j++)
        {
            if (numbers[j].CompareTo(mark[]))
            {

            }
        }
        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine(string.Join(", ", mark));
    }
    }

