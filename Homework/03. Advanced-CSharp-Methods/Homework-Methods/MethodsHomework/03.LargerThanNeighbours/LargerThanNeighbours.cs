using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 3, 4, 5, 1, 0, 5 };

            for (int i = 0; i < values.Length - 1; i++)
            {
                Console.WriteLine(IsGreaterThanNeibhours(values, i));
            }
            Console.WriteLine();

        }

        static bool IsGreaterThanNeibhours (int [] values , int i)
        {
            bool checkIfGreaterThanNeibhours;
            if (i == 0)
            {
                checkIfGreaterThanNeibhours = values[i] > values[i + 1];
                return checkIfGreaterThanNeibhours;
            }
            else if (i + 1 == values.Length - 1)
            {
                checkIfGreaterThanNeibhours = values[i + 1] > values[i];
                return checkIfGreaterThanNeibhours;
            }

            else
            {
                checkIfGreaterThanNeibhours = values[i] > values[i - 1] && values[i] > values[i + 1];
                return checkIfGreaterThanNeibhours;
            }
        }

    }
}
