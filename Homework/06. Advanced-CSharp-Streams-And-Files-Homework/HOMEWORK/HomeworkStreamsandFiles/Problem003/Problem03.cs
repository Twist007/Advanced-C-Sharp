using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class WordCount
{
    static void Main(string[] args)
    {
        using (var wordsReader = new StreamReader("../../words.txt"))
        {
            using (var textReader = new StreamReader("../../text.txt"))
            {
                using (var writer = new StreamWriter("../../result.txt"))
                {
                    var text = textReader.ReadToEnd().ToLower();
                    var result = new SortedDictionary<int, string>();
                    string word;
                    while ((word = wordsReader.ReadLine()) != null)
                    {
                        var pattern = string.Format(@"\b{0}\b", word.ToLower());
                        var match = Regex.Matches(text, pattern);
                        result.Add(match.Count, word);
                    }
                    foreach (var match in result.Reverse())
                    {
                        writer.WriteLine("{0} - {1}", match.Value, match.Key);
                    }
                }
            }
        }
    }
}
