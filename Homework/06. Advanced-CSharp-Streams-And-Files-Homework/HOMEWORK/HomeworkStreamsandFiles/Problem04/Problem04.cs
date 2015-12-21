using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem04
{
    class Problem04
    {
        static void Main(string[] args)
             
        {
            var dog = "../../dog.jpg";
            var DestinationPath = "../../newdog.jpg";
            using (var source = new FileStream(dog, FileMode.Open))
            {
                using (var destination =
                    new FileStream(DestinationPath, FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                            break;

                        destination.Write(buffer, 0, readBytes);
                    }
                }
            }

        }
    }
}
