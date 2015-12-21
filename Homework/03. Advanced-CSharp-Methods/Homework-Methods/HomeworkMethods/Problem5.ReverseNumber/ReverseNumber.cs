using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine(Reverse(num));
        }
        static public double Reverse(double number)
        {
            string numb = Convert.ToString(number);
            char[] arr = numb.ToCharArray();
            Array.Reverse(arr);
            string finalArr = new string(arr);
            double final = Convert.ToDouble(finalArr);
            return final;
        }
    }
}