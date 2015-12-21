using System;
using System.Collections.Generic;

    class PrimeFactorization
{
        static void Main()
        {
        int inputNumber = int.Parse(Console.ReadLine());

        List<int> primeMultiple = new List<int>();
        int divisor = 2;
        int number = inputNumber;

        while (number!=1)
        {
            if (number % divisor == 0)
            {
                number /= divisor;
                primeMultiple.Add(divisor);
            }
            else
            {
                divisor++;
            }
        }

        Console.WriteLine("{0} = {1}", inputNumber, string.Join(" * ", primeMultiple) );
    }
    }

