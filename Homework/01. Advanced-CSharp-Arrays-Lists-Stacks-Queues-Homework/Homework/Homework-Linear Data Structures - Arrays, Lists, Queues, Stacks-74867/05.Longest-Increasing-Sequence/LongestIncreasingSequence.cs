using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Longest_Increasing_Sequence
{
    class LongestIncreasingSequence
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            List<string> inputNums = new List<string>();

            int indexNum = 0;
            int maxLength = 0;
            inputNums.Add(numbers[0] + " ");

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    inputNums[indexNum] += numbers[i] + " ";
                }
                else
                {
                    indexNum++;
                    inputNums.Add(numbers[i] + " ");
                }

                if (maxLength < inputNums[indexNum].Length)
                {
                    maxLength = inputNums[indexNum].Length;
                }
            }

            string longest = "";

            for (int i = 0; i < inputNums.Count; i++)
            {
                if (inputNums[i].Length == maxLength)
                {
                    longest = "Longest: " + inputNums[i];
                }
                Console.WriteLine(inputNums[i]);
            }
            Console.WriteLine(longest);
        }
    }
}
