using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Unicode_Characters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            foreach (var item in inp)
            {
                Console.Write("\\u{0:x4}", (int)item);
            }
            
        }
    }
}
