using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class VladkosNotebook
{
    static void Main()
    {
        var entry = Console.ReadLine();
        Dictionary<string, Player> pagesByColor = new Dictionary<string, Player>();

        while (entry != "END")
        {
            string[] data = entry.Split('|');
            string color = data[0];
            if (!pagesByColor.ContainsKey(color))
            {
                pagesByColor[color] = new Player();
                pagesByColor[color].Opponents = new List<string>();
            }
            //Player currentPlayer = pagesByColor[color];

            // purple | age | 99
            if (data[1] == "age")
            {
                int age = int.Parse(data[2]);
                pagesByColor[color].Age = age;
            }
            //purple|name|VladoKaramfilov
            else if (data[1] == "name")
            {
                pagesByColor[color].Name = data[2];
            }
            //blue|win|Vladko
            else if (data[1] == "win")
            {
                pagesByColor[color].WinCount++;
                pagesByColor[color].Opponents.Add(data[2]);
            }
            //purple|loss|Manov
            else if (data[1] == "loss")
            {
                pagesByColor[color].LostCount++;
                pagesByColor[color].Opponents.Add(data[2]);
            }

            entry = Console.ReadLine();
        }

        var validPages = pagesByColor
              .Where(p => p.Value.Age != 0 && p.Value.Name != null)
              .OrderBy(p => p.Key);

        if (validPages.Count()==0)
        {
            Console.WriteLine("No data recovered.");
        }

        var output = new StringBuilder();
        foreach (var page in validPages)
        {
            output.AppendLine($"Color: {page.Key}");
            output.AppendLine($"-age: {page.Value.Age}");
            output.AppendLine($"-name: {page.Value.Name}");
            var opponentsOutput = "(empty)";
            if (page.Value.Opponents.Count > 0)
            {
                var sortedOpponents = page.Value.Opponents
                .OrderBy(o => o, StringComparer.Ordinal);
                opponentsOutput = string.Join(", ", sortedOpponents);
            }

            output.AppendLine($"-opponents: {opponentsOutput}");
            var rank = (page.Value.WinCount + 1) / (double)(page.Value.LostCount + 1);
            output.AppendLine($"-rank: {rank:f2}");
        }
        Console.WriteLine(output.ToString());
    }
}

internal class Player
{
    //// Construct Player -> za vseki obekt ot Player suzdava list
    //public Player()
    //{
    //   this.Opponents=new List<string>();

    //}

public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Opponents { get; set; }
    public int WinCount { get; set; }
    public int LostCount { get; set; }

}
