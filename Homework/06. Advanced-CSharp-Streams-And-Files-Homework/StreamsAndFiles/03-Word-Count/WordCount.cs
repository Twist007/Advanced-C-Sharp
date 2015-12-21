//Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file text.txt. Matching should be case-insensitive. Write the results in file results.txt.Sort the words by frequency in descending order. Use StreamReader in combination with StreamWriter.


using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class WordCount
{
    static void Main()
    {
        using (var reader = new StreamReader("../../words.txt"))
        {
            using (var writer = new StreamWriter("../../result.txt"))
            {
                Dictionary<string, int> result = new Dictionary<string, int>();
                int countMatches = 0;
                string word = reader.ReadLine();

                while (word != null)
                {
                    using (var textReader = new StreamReader("../../text.txt"))
                    {
                        string lineInText = textReader.ReadLine();
                        while (lineInText != null)
                        {
                            string pattern = string.Format(@"\b{0}\b", word);
                            countMatches += Regex.Matches(lineInText, pattern, RegexOptions.IgnoreCase).Count;
                            lineInText = textReader.ReadLine();
                        }
                    }
                    result.Add(word, countMatches);
                    countMatches = 0;
                    word = reader.ReadLine();
                }

                foreach (var item in result.OrderByDescending(i => i.Value))
                {
                    writer.WriteLine("{0} - {1}", item.Key, item.Value);
                }
            }
        }
    }
}

