using System;
using System.Collections.Generic;
using System.Linq;

namespace SequencesOfEqualStrings
{
    class SequencesOfEqualStrings
    {
        static void Main()
        {
            string[] inputElements = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < inputElements.Length; i++)
            {
                Console.Write(inputElements[i]);
                if (i < inputElements.Length - 1 && (inputElements[i] == inputElements[i + 1]))
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}