using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsHomework
{
    class BiggerNumber
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(firstNumber,secondNumber));
       
        }

        static int GetMax(int firstNumber, int secondNumber)
        {
          int  maxNumber = firstNumber;
            if (secondNumber>firstNumber)
            {
                maxNumber = secondNumber;
            }
            return maxNumber;
        }
    }
}
