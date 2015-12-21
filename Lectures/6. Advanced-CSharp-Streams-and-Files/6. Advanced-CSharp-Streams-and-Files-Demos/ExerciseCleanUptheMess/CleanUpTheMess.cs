using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ExerciseCleanUptheMess
{
    class CleanUpTheMess
    {
        static void Main()
        {
            using (var reader = new StreamReader("../../Mecanismo.cs"))
            {
                using (var writer = new StreamWriter("../../Engine.cs"))
                {
                    string pattern = @"\s*\n\s*";
                    Regex regex = new Regex(pattern);
                    string replace = Environment.NewLine;

                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        
                        string result = regex.Replace(line, replace);
                        Console.WriteLine(result);
                        line = reader.ReadLine();
                    }

                }
            }
        }
    }
}
