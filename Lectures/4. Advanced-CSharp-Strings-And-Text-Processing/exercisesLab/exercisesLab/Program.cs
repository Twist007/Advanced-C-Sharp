using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisesLab
{
    class Program
    {
        static void Main()
        {
            string email = " iorda93@gmail.com";
            string result = CensoreEmail(email);
            Console.WriteLine(result);
            //result = ******@gmail.com

        }

        static string CensoreEmail(string email)
        {
            int index = email.IndexOf("@");
            string mask = new string('*', index);
            string result = mask + email.Substring(index);
            return result;
        }

    }


}
