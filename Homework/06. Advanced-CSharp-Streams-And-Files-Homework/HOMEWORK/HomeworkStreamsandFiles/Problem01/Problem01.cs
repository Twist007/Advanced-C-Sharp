using System;
using System.IO;

class OddLines
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("../../OddLines.cs.txt");
        using (reader)
        {
            int lineNumber = 0;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                lineNumber++;
                if (lineNumber % 2 ==1)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                }
            }
        }
    }
}