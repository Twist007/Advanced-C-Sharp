using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Problem02
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../TextFile.txt"))
            {
                using (var writer = new StreamWriter("../../AnotherFileText.txt"))
                {
                    string line = reader.ReadLine();
                        int numberofLine = 0;
                    while (line != null)
                    {
                        numberofLine++;

                        string writeline = string.Format("Line {0}:{1}", numberofLine, line);
                                writer.Write(writeline);
                        
                        writer.WriteLine();
                        line = reader.ReadLine();
                    }
                }
            }

        }
    }
}
