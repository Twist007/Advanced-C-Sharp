using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class UnicodeCharacters
{
    static void Main()
    {
        string text = Console.ReadLine();

        for (int i = 0; i < text.Length; i++)
        {
            string unicode = "\\u" + ((int)text[i]).ToString("X").PadLeft(4, '0');

            Console.Write(unicode);
        }
        Console.WriteLine();
    }   
}

