
using System;
using System.Linq;
using System.Numerics;

class ArraySlider
{
    static void Main()
    {
        var arr = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToArray();

        int currentIndex = 0;

        string command = Console.ReadLine();
        while (command != "stop")
        {
            var lineArgs = command.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int offset = int.Parse(lineArgs[0]) % arr.Length;
            string operation = lineArgs[1];
            BigInteger operand = BigInteger.Parse(lineArgs[2]);

            if (offset<0)
            {
                currentIndex = (currentIndex + offset + arr.Length)%arr.Length;
            }
            else
            {
                currentIndex = (currentIndex + offset)%arr.Length;
            }

            switch (operation)
            {
                case "&":
                    arr[currentIndex] &= operand;
                    break;
                case "|":
                    arr[currentIndex] |= operand;
                    break;
                case "^":
                    arr[currentIndex] ^= operand;
                    break;
                case "+":
                    arr[currentIndex] += operand;
                    break;
                case "-":
                    arr[currentIndex] -= operand;

                    if (arr[currentIndex]<0)
                    {
                        arr[currentIndex] = 0;
                    }
                    break;
                case "*":
                    arr[currentIndex] *= operand;
                    break;
                case "/":
                    arr[currentIndex] /= operand;
                    break;
            }

            command = Console.ReadLine();
        }
        Console.WriteLine("[{0}]",string.Join(", ", arr));
    }
}

