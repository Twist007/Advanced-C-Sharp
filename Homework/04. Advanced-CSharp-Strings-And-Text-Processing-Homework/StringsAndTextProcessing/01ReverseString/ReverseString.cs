//Write a program that reads a string from the console, reverses it and prints the result back at the console
using System;
using System.Text;
    class ReverseString
    {

    static void Main()
        {
        string inputString = Console.ReadLine();

        StringBuilder strBuilder = new StringBuilder();
        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            strBuilder.Append(inputString[i]);
        }

        Console.WriteLine(strBuilder.ToString());

        //char[] reversed = new char[inputString.Length];
        //for (int i = 0; i < inputString.Length; i++)
        //{
        //    reversed[i] = inputString[inputString.Length-1 - i];
        //}
        //Console.WriteLine(string.Join("", reversed));





    }
}

