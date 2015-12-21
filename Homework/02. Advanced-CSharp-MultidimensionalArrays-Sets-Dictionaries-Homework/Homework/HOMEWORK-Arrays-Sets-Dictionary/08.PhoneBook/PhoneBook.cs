using System;
using System.Collections.Generic;
class Phonebook
{
    static void Main()
    {
        Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();

        string contactInformation = Console.ReadLine();
        string[] contactTokens;
        string contactName = String.Empty;
        string contactNumber = String.Empty;

        while (contactInformation != "search")
        {
            contactTokens = contactInformation.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            contactName = contactTokens[0];
            contactNumber = contactTokens[1];
            if (!phonebook.ContainsKey(contactName))
            {
                phonebook[contactName] = new List<string>();

            }
            phonebook[contactName].Add(contactNumber);

            contactInformation = Console.ReadLine();
        }

        string contactNameToSearch = Console.ReadLine();
        while (!String.IsNullOrEmpty(contactNameToSearch))
        {
            if (phonebook.ContainsKey(contactNameToSearch))
            {
                Console.Write("{0} -> {1}", contactNameToSearch, String.Join(", ", phonebook[contactNameToSearch]));
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", contactNameToSearch);
            }

            contactNameToSearch = Console.ReadLine();
        }
    }
}