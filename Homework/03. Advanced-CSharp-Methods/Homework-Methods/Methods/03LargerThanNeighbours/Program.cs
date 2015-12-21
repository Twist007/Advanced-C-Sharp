using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new[] {1, 3, 4, 5, 1, 0, 5};
            Console.WriteLine("Please enter the elements of the array on a single line separated by intervals");
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(IsLarger(nums, i));
            }
        }

        public static bool IsLarger(int[] arr, int i)
        {
            if (i == 0)
            {
                return arr[i] > arr[i + 1];
            }
            else if (i == arr.Length - 1)
            {
                return arr[i] > arr[i - 1];
            }
            else
            {
                return (arr[i] > arr[i - 1]) && (arr[i] > arr[i + 1]);
            }
        }
    }
}
