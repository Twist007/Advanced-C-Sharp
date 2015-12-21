using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Pr03WordCount
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader(@"..\..\res\words.txt");
        StreamWriter writer = new StreamWriter(@"..\..\res\output.txt");
        List<string> words = new List<string>();
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                words.Add(line);
                line = reader.ReadLine();
            }
        }
        reader = new StreamReader(@"..\..\res\text.txt");
        Dictionary<string, int> output = new Dictionary<string, int>();
        using (reader)
        {
            string text = reader.ReadToEnd();
            char[] splitters = new char[] { ' ', '-', '_', '.', '?', '!', ',', '\n' };
            string[] textSplit = text.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Count; i++)
            {
                int counter = 0;
                foreach (string t in textSplit)
                {
                    if (words[i].Equals(t, StringComparison.InvariantCultureIgnoreCase))
                    {
                        counter++;
                    }
                }
                output.Add(words[i], counter);
            }
        }
        var sortedOutput = output.OrderByDescending(pair => pair.Value);
        using (writer)
        {
            foreach (var pair in sortedOutput)
            {
                writer.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }
        }
        Console.WriteLine("Success!");
    }
}