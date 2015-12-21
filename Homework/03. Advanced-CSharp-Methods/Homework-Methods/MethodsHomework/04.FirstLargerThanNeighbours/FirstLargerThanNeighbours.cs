using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1, 1};

            Console.WriteLine(IndexOfFirstGreaterElement(sequenceOne));
            Console.WriteLine(IndexOfFirstGreaterElement(sequenceTwo));
            Console.WriteLine(IndexOfFirstGreaterElement(sequenceThree));
        }

        static int IndexOfFirstGreaterElement (int [] arr)
        {
            int bestIndex = -1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (i==0 && arr[i] > arr[i + 1])
                {
                    bestIndex = i;
                    break;
                }
                if (i>0 && arr[i] > arr[i -1] && arr[i] > arr[i + 1])
                {
                    bestIndex = i;
                    break;
                }
            }
            return bestIndex;

        }
    }
}
