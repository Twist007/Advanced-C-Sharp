using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string word = Console.ReadLine();

            HowManyTimes(input, word);
        }

        static void HowManyTimes(string input, string find)
        {
            find = find.ToLower();
            int leng = find.Length;
            string toLower = input.ToLower();
            int counter = 0;
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < toLower.Length - leng + 1; i++)
            {
                if (leng == 2)
                {
                    newString.Append(toLower[i]);
                    newString.Append(toLower[i + 1]);
                    if (newString.ToString() == find)
                    {
                        counter++;
                    }
                }
                else if (leng == 3)
                {
                    newString.Append(toLower[i]);
                    newString.Append(toLower[i + 1]);
                    newString.Append(toLower[i + 2]);
                    if (newString.ToString() == find)
                    {
                        counter++;
                    }
                }
                else if (leng == 4)
                {
                    newString.Append(toLower[i]);
                    newString.Append(toLower[i + 1]);
                    newString.Append(toLower[i + 2]);
                    newString.Append(toLower[i + 3]);
                    if (newString.ToString() == find)
                    {
                        counter++;
                    }
                }
                newString.Clear();
            }
            Console.WriteLine(counter);
        }
    }
}
