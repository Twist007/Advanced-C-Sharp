using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayOfNumbers
{
    class arrayOfNumbers
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();
            int temp;

            for (int write = 0; write < arr.Length - 1; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;

                    }

                }

            }
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
