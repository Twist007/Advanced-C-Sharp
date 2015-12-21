//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *. Print the resulting string on the console.
using System;
class StringLenght
{
    static void Main()
    {
        string text = Console.ReadLine();

        if (text.Length > 20)
        {
            Console.WriteLine(text.Substring(0, 20));
        }
        else
        {
            Console.WriteLine(text + new string('*', 20 - text.Length));
        }
    }
}

