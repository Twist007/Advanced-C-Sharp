
using System;
using System.Collections.Generic;

class StuckNumbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> resultList = new List<string>();

        foreach (var a in input)
        {
            foreach (var b in input)
            {
                foreach (var c in input)
                {
                    foreach (var d in input)
                    {
                        if (a != b && a != c && a != d && b != c && b != d && c != d)
                        {
                            if (a + b == c + d)
                            {
                                resultList.Add(string.Format("{0}|{1}=={2}|{3}", a, b, c, d));
                            }
                        }
                    }
                }
            }
        }

        if (resultList.Count > 0)
        {
            Console.WriteLine(string.Join("\n", resultList));
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

