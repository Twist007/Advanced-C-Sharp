using System.IO;
class Pr04CopyBinaryFile
{
    static void Main(string[] args)
    {
        FileStream input = new FileStream(@"..\..\res\pic.jpg", FileMode.Open);
        FileStream output = new FileStream(@"..\..\res\picOutput.jpg", FileMode.Create);
        using (input)
        {
            using (output)
            {
                byte[] buffer = new byte[1024];
                int read = input.Read(buffer, 0, buffer.Length);
                while (read > 0)
                {
                    output.Write(buffer, 0, read);
                    read = input.Read(buffer, 0, buffer.Length);
                }
            }
        }
    }
}