//Write a program that copies the contents of a binary file (e.g. image, video, etc.) to another using FileStream. You are not allowed to use the File class or similar helper classes.

using System;
using System.IO;

class CopyBinaryFile
{
    const string image = "../../wizard.jpg";
    const string copyImage = "../../wizard-copy.png";

    static void Main()
    {
        using (var imageStream = new FileStream(image, FileMode.Open))
        {
            using (var copyStream = new FileStream(copyImage, FileMode.Create))
            {
                byte[] buffer = new byte[4096];

                while (true)
                {
                    int readBytes = imageStream.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }

                    copyStream.Write(buffer, 0, readBytes);
                }
            }
        }
    }
}

