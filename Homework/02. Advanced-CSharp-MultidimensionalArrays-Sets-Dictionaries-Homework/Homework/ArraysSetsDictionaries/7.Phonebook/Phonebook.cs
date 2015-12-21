using System;
using System.Collections.Generic;
class Phonebook
{
    static void Main()
    {
        Console.WriteLine("Enter contacts in the phonebook in the format(name-number).");

        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        string input = Console.ReadLine();


        while (input != "search")
        {
            string[] contact = new string[1];
            contact = input.Split('-');
            phonebook.Add(contact[0], contact[1]);
            input = Console.ReadLine();
        }
        while (true)
        {
            string searchedName = Console.ReadLine();
            if (phonebook.ContainsKey(searchedName))
            {
                Console.WriteLine("{0} -> {1}", searchedName, phonebook[searchedName]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", searchedName);
            }
        }
    }
}
