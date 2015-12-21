using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main()
        {
            var nightClubs = new Dictionary<string, Dictionary<string, List<string>>>();
            string[] input = Console.ReadLine().Split(';');
            do
            {
                string city=input[0];
                string place=input[1];
                string performer=input[2];
                if (nightClubs.ContainsKey(city))
                {
                    if (nightClubs[city].ContainsKey(place))
                    {
                        if (!CheckPerformers(performer,nightClubs[city][place]))
                        {
                            nightClubs[city][place].Add(performer);
                            nightClubs[city][place].Sort();
                        }
                    }
                    else
                    {
                    nightClubs[city].Add(place, new List<string>());
                    nightClubs[city][place].Add(performer);
                    }
                    input = Console.ReadLine().Split(';');
                }
                else
                {
                    nightClubs.Add(city, new Dictionary<string, List<string>>());
                    nightClubs[city].Add(place, new List<string>());
                    nightClubs[city][place].Add(performer);
                }
            }               
            while(input[0]!="END");
            foreach (string city in nightClubs.Keys)
            {
                Console.WriteLine(city);
                var placesList = nightClubs[city].Keys.ToList();
                placesList.Sort();
                foreach (string place in placesList)
                {
                    Console.WriteLine("->{0}: {1}", place, string.Join(", ", nightClubs[city][place]));
                }
            }
        }
        static bool CheckPerformers(string s, List<string> l)
        {
            bool check = false;
            for (int i = 0; i < l.Count; i++)
            {
                if (s == l[i])
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
    }
}
