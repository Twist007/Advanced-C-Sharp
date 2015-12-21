using System;

class StringLength
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        if (text.Length <= 20)
        {
            Console.WriteLine("{0}", text.PadRight(20, '*'));
            
        }
        else
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Write(text[i]);
            }
        }
        Console.WriteLine();

    }
}

