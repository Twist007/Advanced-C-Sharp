using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class selectionSort
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ')
            .Select(int.Parse)
            .ToArray();
        var output = new List<int>();

        for (int index = 0; index < input.Length; index++)
        {
            for (int counter = 0; counter < input.Length; counter++)
            {
                if (input[counter] > input[index])
                {
                    int container = input[index];
                    input[index] = input[counter];
                    input[counter] = container;
                }
            }
        }
        Console.WriteLine(string.Join(" ", input));
    }
}