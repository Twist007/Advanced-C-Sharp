//Being a nerd means writing programs about night clubs instead of actually going to ones. Spiro is a nerd and he decided to summarize some info about the most popular night clubs around the world. He's come up with the following structure – he'll summarize the data by city, where each city will have a list of venues and each venue will have a list of performers.Help him finish the program, so he can stop staring at the computer screen and go get himself a cold beer.You'll receive the input from the console. There will be an arbitrary number of lines until you receive the string "END". Each line will contain data in format: "city;venue;performer". If either city, venue or performer don't exist yet in the database, add them. If either the city and/or venue already exist, update their info.Cities should remain in the order in which they were added, venues should be sorted alphabetically and performers should be unique (per venue) and also sorted alphabetically.Print the data by listing the cities and for each city its venues (on a new line starting with "->") and performers(separated by comma and space). Check the examples to get the idea.And grab a beer when you're done, you deserve it. Spiro is buying.

using System;
using System.Collections.Generic;
  class NightLife

    {
        static void Main()
        {

        Dictionary<string, SortedDictionary<string, SortedSet<string>>> performencs = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
        string command = Console.ReadLine();

        while (command!="END")
        {
            string[] cityVenuePerformer = command.Split(';');
            string city = cityVenuePerformer[0];
            string venue = cityVenuePerformer[1];
            string performer = cityVenuePerformer[2];

            if (!performencs.ContainsKey(city))
            {
                performencs[city] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!performencs[city].ContainsKey(venue))
            {
                performencs[city][venue] = new SortedSet<string>();
            }
            if (!performencs[city][venue].Contains(performer))
            {
                performencs[city][venue].Add(performer);
            }

            command = Console.ReadLine();

           
        }
        foreach (var cityVenue in performencs)
        {
            Console.WriteLine("{0}", cityVenue.Key);

            foreach (var vanuePerformers in cityVenue.Value)
            {
                Console.WriteLine("->{0}: {1}", vanuePerformers.Key, string.Join(", ", vanuePerformers.Value));
            }
        }
    }
    }

