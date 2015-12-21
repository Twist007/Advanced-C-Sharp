//Write a program that receives some info from the console about people and their phone numbers.You are free to choose the manner in which the data is entered; each entry should have just one name and one number(both of them strings). After filling this simple phonebook, upon receiving the command "search", your program should be able to perform a search of a contact by name and print her details in format "{name} -> {number}". In case the contact isn't found, print "Contact {name} does not exist." 

using System;
using System.Collections.Generic;

    class Phonebook
    {
        static void Main()
        {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        string input = Console.ReadLine();
        while (input != "search")
        {
            string name = input.Split('-')[0];
            string number = input.Split('-')[1];
            phonebook.Add(name, number);

            input = Console.ReadLine();
        }

        string searchName = Console.ReadLine();

        while (searchName!="End")
        {
            if (phonebook.ContainsKey(searchName))
            {
                string num;
                phonebook.TryGetValue(searchName, out num);
                Console.WriteLine("{0} -> {1}", searchName, num);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist", searchName);
            }

            searchName = Console.ReadLine();
        }

        }
    }

