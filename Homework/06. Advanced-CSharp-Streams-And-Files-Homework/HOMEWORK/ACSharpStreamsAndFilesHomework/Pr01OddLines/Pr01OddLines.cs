using System;
using System.IO;
class Pr01OddLines
{
    static void Main(string[] args)
    {
        StreamReader oddReader = new StreamReader(@"..\..\res\test.txt");
        using (oddReader)
        {
            int oddCheck = 0;
            string line = oddReader.ReadLine();
            while (line != null)
            {
                if (oddCheck % 2 != 0)
                {
                    Console.WriteLine(line);
                }
                line = oddReader.ReadLine();
                oddCheck++;
            }
        }
    }
}