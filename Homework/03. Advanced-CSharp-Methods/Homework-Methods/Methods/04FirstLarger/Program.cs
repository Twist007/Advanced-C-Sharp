using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04FirstLarger
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new[] {1, 2, 3, 4, 5, 6, 6};
            Console.WriteLine("Please enter the elements of the array on a single line separated by intervals");
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(IndexFirstLarger(nums));
           
        }

        public static int IndexFirstLarger(int[] arr)
        {
            bool isLarger = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    isLarger = arr[i] > arr[i + 1];
                }
                else if (i == arr.Length - 1)
                {
                    isLarger = arr[i] > arr[i - 1];
                }
                else
                {
                    isLarger = (arr[i] > arr[i - 1]) && (arr[i] > arr[i + 1]);
                }

                if (isLarger)
                {
                    return i;
                }
            }                     
            return -1;          
        }
    
    }
}
