using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (var ch in input)
            {
                Console.Write("\\u{0:x4}", Convert.ToUInt16(ch));
            }
            Console.WriteLine();
        }
    }
}
