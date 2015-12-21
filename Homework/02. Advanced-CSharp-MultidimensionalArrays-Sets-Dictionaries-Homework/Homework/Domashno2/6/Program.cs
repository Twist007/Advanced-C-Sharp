using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            var characters = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (characters.ContainsKey(input[i]))
                {
                    characters[input[i]] += 1;
                }
                else
                {
                    characters.Add(input[i], 1);
                }
            }

            var list = characters.Keys.ToList();
            list.Sort();

            foreach (var key in list)
            {
                Console.WriteLine("{0}: {1} time/s", key, characters[key]);
            }
        }
    }
}
