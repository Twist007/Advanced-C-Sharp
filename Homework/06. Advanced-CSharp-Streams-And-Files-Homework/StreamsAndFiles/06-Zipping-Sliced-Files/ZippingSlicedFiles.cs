//Modify your previous program to also compress the bytes while slicing parts and decompress them when assembling them back to the original file. Use GzipStream. Tip: When getting files from directory, make sure you only get files with.gz extension(there might be hidden files).

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

class ZippingSlicedFiles
{
    static void Main()
    {
        int parts = int.Parse(Console.ReadLine());
        string sourceFile = "../../Streams-and-Files.pptx";
        string destinationDirectory = "../../";
        List<string> files = new List<string>();

        for (int i = 0; i < parts; i++)
        {
            files.Add(string.Format("{0}part-{1}.gz", destinationDirectory, i));
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

            int bytesRead;
            while ((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0)
            {
                for (int i = 0; i < bytesRead; i++)
                {
                    data.Add(buffer[i]);
                }
            }

            int sizeOfParts = data.Count / parts;
            int leftOver = data.Count - sizeOfParts * parts;
            for (int i = 0; i < parts; i++)
            {
                string newFile = string.Format("{0}part-{1}.gz", destinationDirectory, i);
                using (var copyFile = new FileStream(newFile, FileMode.Create))
                {
                    using (var zip = new GZipStream(copyFile, CompressionMode.Compress))
                    {

                        if (i == parts - 1)
                        {
                            zip.Write(data.ToArray(), i * sizeOfParts, sizeOfParts + leftOver);
                        }
                        else
                        {
                            zip.Write(data.ToArray(), i * sizeOfParts, sizeOfParts);
                        }
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
                using (var zip = new GZipStream(source, CompressionMode.Decompress))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    while ((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        for (int j = 0; j < bytesRead; j++)
                        {
                            data.Add(buffer[j]);
                        }
                    };
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

