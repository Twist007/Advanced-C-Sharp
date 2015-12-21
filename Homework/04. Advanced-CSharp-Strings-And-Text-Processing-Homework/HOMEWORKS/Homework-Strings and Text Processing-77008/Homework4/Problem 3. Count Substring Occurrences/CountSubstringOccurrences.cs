using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Count_Substring_Occurrences
{
    class CountSubstringOccurrences
    {
        class Program
        {
            static void Main(string[] args)
            {
                string inp = Console.ReadLine().ToLower();
                string outp = Console.ReadLine();

                int count = 0;

                for (int i = 0; i < inp.Length - outp.Length+1; i++)
                {
                    if (string.Compare(inp.Substring(i, outp.Length), outp, true) == 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                
            }

            
        }
    }
}
