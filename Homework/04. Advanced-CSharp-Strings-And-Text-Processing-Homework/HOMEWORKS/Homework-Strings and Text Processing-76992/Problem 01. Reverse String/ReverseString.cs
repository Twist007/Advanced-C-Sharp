using System;


class ReverseString
{
    static void Main()
    {
        string text = Console.ReadLine();

        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(text[text.Length-1-i]);
        }
    }
}

