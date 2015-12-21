using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SubsetSums
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int combinations = (int)Math.Pow(2, arr.Length);
        bool match = false;
        List<int> sub = new List<int>();
        for (int i = 0; i < combinations; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {

                if ((i & (1 << j)) != 0)
                {
                    sub.Add(arr[j]);
                }

            }
            if (sub.Sum() == sum)
            {
                Console.WriteLine("{0} = {1}", string.Join(" + ", sub), sum);
                match = true;
            }
            sub.Clear();

        }
        if (match == false)
        {
            Console.WriteLine("No matching subsets.");
        }

    }
}