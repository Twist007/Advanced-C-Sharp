using System;
using System.Collections.Generic;

class CouplesFrequency
{
    static void Main()
    {
        string[] inputIntegers = Console.ReadLine().Split();

        int totalNumberOfCouple = inputIntegers.Length - 1;
        var coupleOfFrequencies = new Dictionary<string, int>();

        for (int i = 1; i < inputIntegers.Length; i++)
        {
            string currentCouple = string.Format("{0} {1}", inputIntegers[i - 1], inputIntegers[i]);

            if (!coupleOfFrequencies.ContainsKey(currentCouple))
            {
                coupleOfFrequencies.Add(currentCouple, 0);
            }
            coupleOfFrequencies[currentCouple]++;
        }

        foreach (var frequency in coupleOfFrequencies)
        {
            double percentage = frequency.Value * 100.0 / totalNumberOfCouple;
            Console.WriteLine("{0} -> {1:f2}%", frequency.Key, percentage);
        }
    }
}

