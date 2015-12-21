using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] arr = input.Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(arr));
        }
        static public int GetIndexOfFirstElementLargerThanNeighbours(int[] array)
        {
            for (int a = 0; a < array.Length; a++)
            {
                if (a == 0)
                {
                    if (array[a] > array[a + 1])
                    {
                        return a;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (a == array.Length - 1)
                {
                    if (array[a - 1] < array[a])
                    {
                        return a;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    if (array[a] > array[a - 1] && array[a] > array[a + 1])
                    {
                        return a;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return -1;
        }
    }
}
