using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            ReplaceWithAsteriks(input);
        }

        static void ReplaceWithAsteriks(string input)
        {
            int leng = input.Length;
            if (leng > 19)
            {
                Console.WriteLine(input.Substring(0,20));
            } else
            {
                string asteriks = new string('*', 20 - leng);
                Console.WriteLine(input + asteriks);
            }
        }
    }
}
