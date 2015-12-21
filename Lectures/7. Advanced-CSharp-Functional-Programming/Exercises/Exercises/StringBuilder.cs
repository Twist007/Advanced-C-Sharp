using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public static class StringBuilder
    {

        public static string NewString(this string inputString)
        {
            return inputString + "1234";


        }

        static void Main()
        {
            string word = "Pesho";
            string newWord = "Gosho";
            string wordNumber=word.NewString();
            Console.WriteLine(wordNumber+newWord);

        }
    }
}
