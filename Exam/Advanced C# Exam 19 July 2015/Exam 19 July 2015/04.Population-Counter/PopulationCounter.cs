
using System;
using System.Collections.Generic;
using System.Linq;

class PopulationCounter
{
    static void Main()
    {
        var line = Console.ReadLine();
        
        Dictionary<string, Dictionary<string, long>> countryData = new Dictionary<string, Dictionary<string, long>>();
        while (line != "report")
        {
            string[] lineArr = line.Split('|');
            string city = lineArr[0];
            string country = lineArr[1];
            long population = long.Parse(lineArr[2]);

            if (!countryData.ContainsKey(country))
            {
                countryData[country] = new Dictionary<string, long>(); //countryData.Add( country, new Dictionary<string, ulong>(); 
               // countryData[country].Add("Total population", 0); //Hack
            }
            countryData[country].Add(city, population);
            // countryData[country]["Total population"] += population; //Hack

            line = Console.ReadLine();
        }

        //foreach (var pair in countryData.OrderByDescending(c => c.Value["Total population"])) ////Hack
        //{
        //    Console.WriteLine("{0} (total population: {1})", pair.Key, pair.Value["Total population"]);
        //    foreach (var source in pair.Value.OrderByDescending(c => c.Value))
        //    {
        //        if (source.Key== "Total population")
        //        {
        //            continue;
        //        }
        //        Console.WriteLine("=>{0}: {1}", source.Key, source.Value);
        //    }
        //}

        foreach (var pair in countryData.OrderByDescending(c => c.Value.Sum(s => s.Value)))
        {
            Console.WriteLine("{0} (total population: {1})", pair.Key, pair.Value.Sum(s => s.Value));
            foreach (var source in pair.Value.OrderByDescending(c => c.Value))
            {
                Console.WriteLine("=>{0}: {1}", source.Key, source.Value);
            }
        }
    }
}

