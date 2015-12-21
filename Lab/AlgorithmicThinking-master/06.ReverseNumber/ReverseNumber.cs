namespace _06.ReverseNumber
{
    using System;

    class ReverseNumber
    {
        static void Main()
        {
            Console.Write("Insert num = ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNum(num));
        }

        static int ReverseNum(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }


            return result;
        }
    }
}
