using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Max_Average_Categorization
{
    class MinMaxAverage
    {
        static void Main(string[] args)
        {
            double[] inputNumers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            List<double> roundNumbers = new List<double>();
            List<double> floatingNumbers = new List<double>();

            for (int i = 0; i < inputNumers.Length; i++)
            {
                if (inputNumers[i] % 1 == 0)
                {
                    roundNumbers.Add(inputNumers[i]);
                }
                else
                {
                    floatingNumbers.Add(inputNumers[i]);
                }
            }
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3:f3}, avg: {4:f3}", 
                string.Join(", ", floatingNumbers),
                floatingNumbers.Min(),
                floatingNumbers.Max(),
                floatingNumbers.Sum(),
                floatingNumbers.Average());
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3:}, avg: {4}",
                string.Join(", ", roundNumbers),
                roundNumbers.Min(),
                roundNumbers.Max(),
                roundNumbers.Sum(),
                roundNumbers.Average());
        }       

    }
}
