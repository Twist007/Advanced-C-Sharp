using System;

class SortArrayOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");

        int n = int.Parse(Console.ReadLine());
        int[] sequence = new int[n];

        Console.WriteLine("Now, enter \"n\" numbers to see the sort numbers: ");

        for (int i = 0; i < sequence.Length; i++)
        {
            Console.Write("{0} number is: ", i + 1);
            sequence[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        Console.WriteLine("Sort numbers are: ");

        for (int i = 0; i < sequence.Length; i++)
        {
            Array.Sort(sequence);

            Console.Write(sequence[i] + " ");
        }

    }
}





//using System;
//using System.Runtime.Remoting.Services;

//class SortArrayOfNumbers
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        int []values = new int[n];

//        for (int i = 0; i < values.Length; i++)
//        {
//            Console.Write("{0} number is: ", i + 1);
//            values[i] = int.Parse(Console.ReadLine());
//        }

//        for (int i = 0; i < values.Length; i++)
//        {
//            Array.Sort(values);
//            Console.Write(values + " ");

//        }


//    }
//}
