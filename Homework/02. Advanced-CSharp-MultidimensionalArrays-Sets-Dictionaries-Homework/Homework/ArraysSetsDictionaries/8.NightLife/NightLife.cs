using System;
using System.Collections.Generic;
class NightLife
{
    static void Main()
    {
        Dictionary<string, SortedDictionary<string, SortedSet<string>>> nightLife = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

        string input = Console.ReadLine();
        string[] cityVenuePerformer;
        string city = string.Empty;
        string venue = string.Empty;
        string performer = string.Empty;

        while (input != "END")
        {
            cityVenuePerformer = input.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            city = cityVenuePerformer[0];
            venue = cityVenuePerformer[1];
            performer = cityVenuePerformer[2];

            if (nightLife.ContainsKey(city))
            {
                if (nightLife[city].ContainsKey(venue))
                {
                    nightLife[city][venue].Add(performer);
                }
                else
                {
                    nightLife[city].Add(venue, new SortedSet<string>());
                }
            }
            else
            {
                nightLife.Add(city, new SortedDictionary<string, SortedSet<string>>());
                nightLife[city].Add(venue, new SortedSet<string>());
                nightLife[city][venue].Add(performer);
            }

            input = Console.ReadLine();
        }

        PringDictionary(nightLife);
    }

    static void PringDictionary(Dictionary<string, SortedDictionary<string, SortedSet<string>>> nightlife)
    {
        foreach (var city in nightlife)
        {
            Console.WriteLine(city.Key);
            foreach (var venue in city.Value)
            {
                Console.WriteLine("-> {0}: {1}", venue.Key, string.Join(", ", venue.Value));
            }         
        }
    }
}
