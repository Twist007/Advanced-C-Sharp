using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            // Input Line
            string[] inp = Console.ReadLine().Split(new char[] { ',', ';', ' ', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            // Storing data
            List<string> reversed = new List<string>();

            // Going through the Input
            for (int i = 0; i < inp.Length; i++)
            {

                string currentReversed = Reverse(inp[i]);
                if (inp[i] == currentReversed)
                {
                    reversed.Add(inp[i]);
                }
            }
            reversed.Sort();
            Console.WriteLine(string.Join(", ", reversed));
        }
        //Reversion algorithm
        static string Reverse(string reversing)
        {
            char[] array = reversing.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}