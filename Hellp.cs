
cr--> Console.ReadLine();

cl--> List<var> name = new List<var>();

ca--> var[] name = new var[size];

cri--> int.Parse(Console.ReadLine());

ipr--> int name = int.Parse(Console.ReadLine());

str--> string name = Console.ReadLine();

ns--> new string(name, value)

stw--> string name = "value";

>>>
using System.Globalization;
using System.Threading;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
>>>
string[] numbersAsStrings = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
<<<
int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();  

 List<int> numbers = new List<int>(Array.ConvertAll(input.Split(' '), int.Parse));
>>>
int[] arr = { 1, 2, 3 };
arr.ToList().ForEach(a => Console.WriteLine(a));
Console.WriteLine(string.Join(", ", arr)); 
<<<

prop -->  public int MyProperty { get; set; }

>>>

forr--> for (int i = length - 1; i >= 0; i--)

>>>
using (var reader = new StreamReader("../../Lines.txt"))
        {
            using (var writer = new StreamWriter("../../NumberLines.txt"))
            {
                int countLine = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine("{0} {1}", countLine, line);

                    countLine++;
                    line = reader.ReadLine();
                }
            }
        }
>>>
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