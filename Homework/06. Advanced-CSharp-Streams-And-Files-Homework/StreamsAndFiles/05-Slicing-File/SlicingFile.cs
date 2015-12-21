//Write a program that takes any file and slices it to n parts. Write the following methods: Slice(string sourceFile, string destinationDirectory, int parts) - slices the given source file into n parts and saves them in destinationDirectory. Assemble(List<string> files, string destinationDirectory) - combines all files into one, in the order they are passed, and saves the result in destinationDirectory. Use FileStreams.You are not allowed to use the File class or similar helper classes.

using System;
using System.Collections.Generic;
using System.IO;

class SlicingFile
{
    static void Main()
    {
        int parts = int.Parse(Console.ReadLine());
        string sourceFile = "../../Streams-and-Files.pptx";
        string destinationDirectory = "../../";
        List<string> files = new List<string>();

        for (int i = 0; i < parts; i++)
        {
            files.Add(string.Format("{0}part-{1}.txt", destinationDirectory, i));
        }

        Slice(sourceFile, destinationDirectory, parts);
        Assemble(files, destinationDirectory);

    }

    static void Slice(string sourceFile, string destinationDirectory, int parts)
    {
        using (var source = new FileStream(sourceFile, FileMode.Open))
        {
            byte[] buffer = new byte[4096];
            List<byte> data = new List<byte>();

            while (true)
            {
                int readBytes = source.Read(buffer, 0, buffer.Length);
                if (readBytes == 0)
                {
                    break;
                }

                for (int i = 0; i < readBytes; i++)
                {
                    data.Add(buffer[i]);
                }
            }
            int sizeOfParts = data.Count / parts;
            int leftOver = data.Count - sizeOfParts * parts;
            for (int i = 0; i < parts; i++)
            {
                string newFile = string.Format("{0}part-{1}.txt", destinationDirectory, i);
                using (var copyFile = new FileStream(newFile, FileMode.Create))
                {
                    if (i == parts - 1)
                    {
                        copyFile.Write(data.ToArray(), i * sizeOfParts, sizeOfParts + leftOver);
                    }
                    else
                    {
                        copyFile.Write(data.ToArray(), i * sizeOfParts, sizeOfParts);
                    }
                }
            }
        }

    }

    static void Assemble(List<string> files, string destinationDirectory)
    {
        var data = new List<byte>();
        for (int i = 0; i < files.Count; i++)
        {
            var sourceFile = files[i];
            using (var source = new FileStream(sourceFile, FileMode.Open))
            {
                byte[] buffer = new byte[4096];
                while (true)
                {
                    int readBytes = source.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }

                    for (int j = 0; j < readBytes; j++)
                    {
                        data.Add(buffer[j]);
                    }
                }
            }
        }
        string copySource = string.Format("{0}Streams-and-Files-Copy.pptx", destinationDirectory);
        using (var copy = new FileStream(copySource, FileMode.Create))
        {
            copy.Write(data.ToArray(), 0, data.Count);
        }

    }
}


