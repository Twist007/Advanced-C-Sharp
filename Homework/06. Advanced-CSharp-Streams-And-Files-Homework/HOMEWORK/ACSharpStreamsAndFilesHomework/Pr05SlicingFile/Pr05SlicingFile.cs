using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Pr05SlicingFile
{
    static void Main(string[] args)
    {
        string sourceFile = @"..\..\res\Pink Floyd - Proper Education.mp3";
        string destinationDirectory = @"..\..\res\parts\";
        int parts = 5;
        if (!Directory.Exists(destinationDirectory))
        {
            Directory.CreateDirectory(destinationDirectory);
        }
        List<string> files = Slice(sourceFile, destinationDirectory, parts);
        Assemble(files, destinationDirectory);
    }

    static List<string> Slice(string sourceFile, string destinationDirectory, int parts)
    {
        FileStream source = new FileStream(sourceFile, FileMode.Open);
        long partLength = source.Length / parts;
        List<string> files = new List<string>();
        string name;
        using (source)
        {
            for (int i = 0; i < parts - 1; i++)
            {
                name = @"Part-" + i + ".mp3";
                FileStream partI = new FileStream(destinationDirectory + name, FileMode.Create);
                using (partI)
                {
                    for (int k = 0; k < partLength; k++)
                    {
                        int b = source.ReadByte();
                        partI.WriteByte((byte) b);
                    }
                }
                files.Add(name);
            }
            name = @"Part-" + (parts - 1) + ".mp3";
            FileStream partR = new FileStream(destinationDirectory + name, FileMode.Create);
            using (partR)
            {
                int b = source.ReadByte();
                while (b >= 0)
                {
                    partR.WriteByte((byte)b);
                    b = source.ReadByte();
                }
            }
            files.Add(name);
        }
        return files;
    }

    private static void Assemble(List<string> files, string destinationDirectory)
    {
        FileStream writer = new FileStream(destinationDirectory + "assembled.mp3", FileMode.Create);
        using (writer)
        {
            foreach (string file in files)
            {
                FileStream reader = new FileStream(destinationDirectory + file, FileMode.Open);
                using (reader)
                {
                    byte[] buffer = new byte[1024];
                    int read = reader.Read(buffer, 0, buffer.Length);
                    while (read > 0)
                    {
                        writer.Write(buffer, 0, read);
                        read = reader.Read(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}