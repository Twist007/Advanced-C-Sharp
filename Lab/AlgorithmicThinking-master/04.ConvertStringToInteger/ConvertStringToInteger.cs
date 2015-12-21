namespace _04.ConvertStringToInteger
{
    using System;
    using System.Text.RegularExpressions;

    class ConvertStringToInteger
    {
        private static bool negativeNum = false;
        static void Main()
        {
            Console.Write("Insert num = ");
            string num = Console.ReadLine();

            ValidateString(num);
            num = ValidateNum(num);

            int output = 0;

            for (int i = num.Length - 1, multiplier = 1; i >= 0; i--, multiplier *= 10)
            {
                output += ConvertToInt(num[i]) * multiplier;
            }

            if (negativeNum)
            {
                output *= -1;
            }

            Console.WriteLine("Num: {0} (Type: {1})", output, output.GetType());
        }

        private static string ValidateNum(string num)
        {
            if (num[0] == '-')
            {
                negativeNum = true;
                num = num.Substring(1);

                if (!Regex.IsMatch(num,
                    @"\b([0-9]{1,9}|1[0-9]{9}|2(0[0-9]{8}|1([0-3][0-9]{7}|4([0-6][0-9]{6}|7([0-3][0-9]{5}|4([0-7][0-9]{4}|8([0-2][0-9]{3}|3([0-5][0-9]{2}|6([0-3][0-9]|4[0-8])))))))))\b"))
                {
                    throw new OverflowException("This number will overflow Int.32");
                }
            }
            else
            {
                if (!Regex.IsMatch(num,
                    @"\b([0-9]{1,9}|1[0-9]{9}|2(0[0-9]{8}|1([0-3][0-9]{7}|4([0-6][0-9]{6}|7([0-3][0-9]{5}|4([0-7][0-9]{4}|8([0-2][0-9]{3}|3([0-5][0-9]{2}|6([0-3][0-9]|4[0-7])))))))))\b"))
                {
                    throw new OverflowException("This number will overflow Int.32");
                }
            }

            return num;
        }

        private static void ValidateString(string num)
        {
            if (!Regex.IsMatch(num, @"^[-]?\d+$"))
            {
                throw new ArgumentException("This is not a number");
            }
        }

        static int ConvertToInt(char ch)
        {
            return ch - '0';
        }
    }
}
