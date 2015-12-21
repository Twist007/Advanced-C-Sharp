using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LastDigitOfNumber
{
    class LastDigitOfNumber
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            Console.WriteLine(LastDigitAsWord(digit));
        }

        static string LastDigitAsWord (int digit)
        {

            int lastDigit = digit % 10;

            switch (lastDigit)
            {
                case 0: return "Zero"; break;
                case 1: return"One"; break;
                case 2: return "Two"; break;
                case 3: return "Three"; break;
                case 4: return "Four"; break;
                case 5: return "Five"; break;
                case 6: return "Six"; break;
                case 7: return "Seven"; break;
                case 8: return "Eight"; break;
                case 9: return "Nine"; break;

                default:return "Not a digit";
                    break;
            }
            
        }
    }
}
