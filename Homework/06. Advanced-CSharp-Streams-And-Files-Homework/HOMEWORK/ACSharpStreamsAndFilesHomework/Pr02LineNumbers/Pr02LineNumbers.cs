using System;
using System.IO;
using System.Text;
class Pr02LineNumbers
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(@"..\..\res\input.txt");
        StreamWriter writer = new StreamWriter(@"..\..\res\output.txt");
        StringBuilder textBuilder = new StringBuilder();
        using (reader)
        {
            int lineNum = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                textBuilder.Append(lineNum);
                textBuilder.Append(" ");
                textBuilder.Append(line);
                textBuilder.Append(Environment.NewLine);
                line = reader.ReadLine();
                lineNum++;
            }
        }
        using (writer)
        {
            writer.Write(textBuilder.ToString());
        }
        Console.WriteLine("Success!");
    }
}