//Write a program that reads a text file and prints on the console its odd lines.Line numbers starts from 0. Use StreamReader.

using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        var reader = new StreamReader("../../Lines.txt");
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                bool isOdd = lineNumber % 2 != 0;
                Console.WriteLine("Line {0}: {1} ; Odd => {2}", lineNumber, line, isOdd);
                lineNumber++;
                line = reader.ReadLine();
            }


        }


    }
}

