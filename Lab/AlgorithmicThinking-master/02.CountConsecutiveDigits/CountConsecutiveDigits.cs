namespace _02.CountConsecutiveDigits
{
    using System;
    using System.Linq;

    class CountConsecutiveDigits
    {
        private static int strike = 1;

        static void Main()
        {
            Console.Write("Insert series of integers, one after another = ");
            int[] nums = Console.ReadLine()
                .ToCharArray()
                .Select(i => int.Parse(i.ToString()))
                .ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                while (true)
                {
                    if ((i + 1) >= nums.Length)
                    {
                        Print(nums, i);
                        strike = 1;
                        break;
                    }

                    if (nums[i] != nums[i + 1])
                    {
                        Print(nums, i);
                        strike = 1;
                        break;
                    }

                    strike++;
                    i++;
                }
            }

            Console.WriteLine();
        }

        static void Print(int[] nums, int index)
        {
            Console.Write("{0}{1}", strike, nums[index]);
        }
    }
}
