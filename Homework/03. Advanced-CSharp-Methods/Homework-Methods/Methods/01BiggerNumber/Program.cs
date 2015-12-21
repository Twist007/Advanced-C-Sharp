using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01BiggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            int max = GetMax(numOne, numTwo);

            Console.WriteLine(max);
        }


        public static int GetMax(int one, int two)
        {
            int max = Math.Max(one, two);
            return max;
        }
    }
}
