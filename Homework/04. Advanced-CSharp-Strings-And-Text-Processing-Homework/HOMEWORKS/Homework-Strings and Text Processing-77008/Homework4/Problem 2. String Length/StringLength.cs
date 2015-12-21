using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.String_Length
{
    class StringLength
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            if (inp.Length <=20)
            {
                Console.WriteLine(inp + new string('*', 20-inp.Length));
            }
            else
            {
                string output = inp.Remove(20,inp.Length-20);
                Console.WriteLine(output);
            }
        }
    }
}
