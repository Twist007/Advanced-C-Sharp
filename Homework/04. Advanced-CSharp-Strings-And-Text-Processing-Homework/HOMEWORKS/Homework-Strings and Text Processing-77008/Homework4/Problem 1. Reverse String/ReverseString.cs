using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Reverse_String
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            string outp = "";
            for (int i = inp.Length - 1; i >= 0; i--)
            {
                outp += inp[i];
            }
            Console.WriteLine(outp);

        }
        
    }
}
