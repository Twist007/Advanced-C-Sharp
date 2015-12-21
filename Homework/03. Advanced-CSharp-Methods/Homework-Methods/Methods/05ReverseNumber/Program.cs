using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            
            Console.WriteLine(ReverseNumber(num));
        }

        public static string ReverseNumber(string rev)
        {
            char[] digits = new char[rev.Length];

            for (int i = 0; i < rev.Length; i++)
            {
                digits[digits.Length - 1 - i] = rev[i];
            }

            return new string(digits);
        }
    }
}
