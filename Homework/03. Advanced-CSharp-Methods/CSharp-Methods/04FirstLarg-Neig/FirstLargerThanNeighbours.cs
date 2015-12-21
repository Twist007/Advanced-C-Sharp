//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1 if there's no such element. Use the method from the previous exercise in order to re.
using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(GetIndexOfFitstElementLargerThenNeigbours(sequence));
    }

    static int GetIndexOfFitstElementLargerThenNeigbours(int[] sequence)
    {
        for (int i = 0; i < sequence.Length; i++)
        {

            if (i - 1 >= 0 && i + 1 < sequence.Length)
            {
                if (sequence[i] > sequence[i - 1] && sequence[i] > sequence[i + 1])
                {
                    return i;
                }
            }
            else if (i - 1 >= 0)
            {
                if (sequence[i] > sequence[i - 1])
                {
                    return i;
                }
            }
            else if (i + 1 < sequence.Length)
            {
                if (sequence[i] > sequence[i + 1])
                {
                    return i;
                }
            }
        }

        return -1;

    }
}

