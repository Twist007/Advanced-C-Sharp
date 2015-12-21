using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FillMatrixSecond
{
    static void Main()
    {
        Console.Write("Input the height and weight: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int element = 1;
        

       for(int col = 0; col < n; col++)
       {
           if(col % 2 == 0)
           {
               for(int row = 0; row < n; row++)
               {
                   matrix[row, col] = element;
                   element++;
               }
           }
           else
           {
               for (int row = n - 1; row >= 0; row--)
               {
                   matrix[row, col] = element;
                   element++;
               }
           }
       }

        for(int row = 0; row < n; row++)
        {
            for(int col = 0; col < n; col++)
            {
                Console.Write("{0,2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
