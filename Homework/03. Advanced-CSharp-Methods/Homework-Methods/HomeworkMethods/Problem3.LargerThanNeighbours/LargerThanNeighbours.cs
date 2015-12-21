using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] arr = input.Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(arr, i));
            }
        }
        static public bool IsLargerThanNeighbours(int[] array, int a)
        {
            if (a == 0)
            {
                if (array[a] < array[a + 1])
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (a == array.Length - 1)
            {
                if (array[a - 1] < array[a])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (array[a] > array[a - 1] && array[a] > array[a + 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

