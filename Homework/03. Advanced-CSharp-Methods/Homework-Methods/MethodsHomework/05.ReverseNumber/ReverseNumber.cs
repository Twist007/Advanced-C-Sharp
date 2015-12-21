using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ReverseNumber
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(ReversString(input));
        }
        static string ReversString (string input)
        {
            char[] charArr = input.ToCharArray();
            Array.Reverse(charArr);
            string result = String.Join("",charArr);
            return result;
        }
    }
}
