using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TextFilter
{
    class Filter
    {
        static void Main(string[] args)
        {
            string[] bannedW = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder text = new StringBuilder(Console.ReadLine());

            string[] bannedS = new string[bannedW.Count()];
            for (int i = 0; i < bannedW.Count(); i++)
            {
                bannedS[i] = new string('*', bannedW[i].Count());
                text.Replace(bannedW[i], bannedS[i]);
            }
            Console.WriteLine();
            Console.WriteLine(text);
        }
    }
}