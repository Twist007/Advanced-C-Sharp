using System;
using System.Collections.Generic;
class JoinLists
{
    static void Main()
    {
        string[] inputFirstArray = Console.ReadLine().Split();
        int[] firsArray = new int[inputFirstArray.Length];
        for (int i = 0; i < inputFirstArray.Length ; i++)
        {
            firsArray[i] = int.Parse(inputFirstArray[i]);    
        }

        string[] inputSecondArray = Console.ReadLine().Split();
        int[] seocondArray = new int[inputSecondArray.Length];
        for (int i = 0; i < inputSecondArray.Length; i++)
        {
            seocondArray[i] = int.Parse(inputSecondArray[i]);
        }

        List<int> joinNumbers = new List<int>();
        for (int i = 0; i < firsArray.Length; i++)
        {
            joinNumbers.Add(firsArray[i]);
        }

        for (int i = 0; i < seocondArray.Length; i++)
        {
            for (int j = 0; j < firsArray.Length; j++)
            {
                if (seocondArray[i]== joinNumbers[j])
                {
            //        joinNumbers.Remove(joinNumbers[j]);
                }
            }
        }

       for (int i = 0; i < seocondArray.Length; i++)
			{
           joinNumbers.Add(seocondArray[i]);
			}

        joinNumbers.Sort();
        Console.WriteLine(string.Join(" ", joinNumbers));
    }
}

