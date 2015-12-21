//Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file. Use StreamReader in combination with StreamWriter.
using System.IO;

class LineNumbers
{
    static void Main()
    {
        using (var reader = new StreamReader("../../Lines.txt"))
        {
            using (var writer = new StreamWriter("../../NumberLines.txt"))
            {
                int countLine = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine("{0} {1}", countLine, line);

                    countLine++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}

