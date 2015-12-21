using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArraySort
{
    class GenericArraySort
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 4, 5, 1, 0, 5 };
            string[] arr = { "zaz", "cba", "baa", "azis" };
            DateTime[] dates = { new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1) };
            if (array.GetType() == typeof(System.Int32[]))
            {
                Sort(array);
                for (int i = 0; i < array.Length;i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.WriteLine();
            if (arr.GetType() == typeof(System.String[]))
            {
                Sort(arr);
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
            if (dates.GetType() == typeof(System.DateTime[]))
            {
                Sort(dates);
                for (int i = 0; i < dates.Length; i++)
                {
                    Console.Write(dates[i] + " ");
                }
            }
            Console.WriteLine();
        }

        public static int[] Sort(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[k] < array[i])
                    {
                        int tmp = array[i];
                        array[i] = array[k];
                        array[k] = tmp;
                    }
                }
            }
            return array;
        }
        public static string[] Sort(string[] array)
        {
            Array.Sort(array);
            return array;
        }
        public static DateTime[] Sort(DateTime[] array)
        {
            Array.Sort(array);
            return array;
        }
    }
}
