using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LastDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string word = GetLastDigit(number);
            Console.WriteLine(word);
        }

        public static string GetLastDigit(string num)
        {
            char digit = num[num.Length - 1];

            switch (digit)
            {
                case '0':
                    return "zero";
                case '1':
                    return "one";
                case '2':
                    return "two";
                case '3':
                    return "three";
                case '4':
                    return "four";
                case '5':
                    return "five";
                case '6':
                    return "six";
                case '7':
                    return "seven";
                case '8':
                    return "eight";
                case '9':
                    return "nine";
                default:
                    return "wrong input";


            }
        }
    }
}
