using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence_Of_Equal_Strings
{
    class equalStrings
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine()
                .Split(' ')
                .ToArray();

            for (int i = 0; i < inputs.Length; i++)
            {
                Console.Write(inputs[i]);
                if ((i < inputs.Length - 1) && (inputs[i] == inputs[i +1]))
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.WriteLine();
                }

            }

        }
    }
}
