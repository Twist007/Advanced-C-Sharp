using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ArrayManipulator
{
    static void Main()
    {
        List<string> sequences = Console.ReadLine().Split().ToList();

        string command = Console.ReadLine();
        while (command != "end")
        {
            string[] commandArguments = command.Split();
            switch (commandArguments[0])
            {
                case "exchange":
                    ExecuteExchangeCommand(int.Parse(commandArguments[1]), sequences);
                    break;
                case "max":
                    //if odd/even
                    ExecuteMaxCommand(commandArguments[1], sequences);
                    break;
                case "min":
                    ExecuteMinCommand(commandArguments[1], sequences);
                    // if odd/even
                    break;
                case "first":
                    // {count} odd/even
                    ExecuteFirstOECommand(commandArguments, sequences);
                    break;
                case "last":
                    ExecuteLastOECommand(commandArguments, sequences);
                    //{count} odd/even
                    break;
            }

            command = Console.ReadLine();
        }
        Console.WriteLine("[{0}]", string.Join(", ", sequences));
    }

    private static void ExecuteExchangeCommand(int commandArgument, List<string> sequences)
    {
        List<string> result = new List<string>();
        if (commandArgument >= 0 && commandArgument < sequences.Count)//>0;<=sequences.count
        {
            int lenght = commandArgument + 1;
            for (int i = 0; i < lenght; i++)
            {
                result.Add(sequences[i]);

            }
            sequences.RemoveRange(0, lenght);
            for (int j = 0; j < result.Count; j++)
            {
                sequences.Add(result[j]);
            }
        }
        else
        {
            Console.WriteLine("Invalid index");
        }


    }

    private static void ExecuteLastOECommand(string[] commandArguments, List<string> sequences)
    {
        List<string> result = new List<string>();
        int count = int.Parse(commandArguments[1]);
        if (commandArguments[2] == "even")
        {
            if (count <= sequences.Count)
            {
                for (int i = 0; i < sequences.Count; i++)
                {
                    if (int.Parse(sequences[i]) % 2 == 0)
                    {
                        result.Add(sequences[i]);
                    }
                }
                result.Reverse();
                List<string> revList = new List<string>();
              
                if (result.Count != 0 && result.Count > count)
                {
                    for (int j = 0; j < count; j++)
                    {
                        revList.Add(result[j]);
                    }
                }
                else
                {
                    for (int j = 0; j < result.Count; j++)
                    {
                        revList.Add(result[j]);
                    }
                }
                revList.Reverse();
                Console.WriteLine("[{0}]", string.Join(", ", revList));

            }
            else
            {
                Console.WriteLine("Invalid count");
            }

        }
        else if (commandArguments[2] == "odd")
        {
            if (count <= sequences.Count)
            {
                for (int i = 0; i < sequences.Count; i++)
                {
                    if (int.Parse(sequences[i]) % 2 != 0)
                    {
                        result.Add(sequences[i]);
                    }
                }
                result.Reverse();
                List<string> revList = new List<string>();
                if (result.Count != 0 && result.Count > count)
                {
                    for (int j = 0; j < count; j++)
                    {
                        revList.Add(result[j]);
                    }
                }
                else
                {
                    for (int j = 0; j < result.Count; j++)
                    {
                        revList.Add(result[j]);
                    }
                }
                revList.Reverse();
                Console.WriteLine("[{0}]", string.Join(", ", revList));
            }
            else
            {
                Console.WriteLine("Invalid count");
            }
        }
    }

    private static void ExecuteFirstOECommand(string[] commandArgument, List<string> sequences)
    {
        List<string> result = new List<string>();
        int count = int.Parse(commandArgument[1]);
        if (commandArgument[2] == "even")
        {
            if (count <= sequences.Count)
            {
                for (int i = 0; i < sequences.Count; i++)
                {
                    if (int.Parse(sequences[i]) % 2 == 0)
                    {
                        result.Add(sequences[i]);
                    }
                }
                var sb = new StringBuilder();
                if (result.Count != 0 && result.Count > count)
                {
                    for (int j = 0; j < count; j++)
                    {
                        sb.AppendFormat("{0}, ", result[j]);
                    }

                }
                else
                {
                    for (int j = 0; j < result.Count; j++)
                    {
                        sb.AppendFormat("{0}, ", result[j]);
                    }
                }
                Console.WriteLine("[{0}]", sb.ToString().TrimEnd(',', ' '));


            }
            else
            {
                Console.WriteLine("Invalid count");
            }

        }
        else if (commandArgument[2] == "odd")
        {
            if (count <= sequences.Count)
            {
                for (int i = 0; i < sequences.Count; i++)
                {
                    if (int.Parse(sequences[i]) % 2 != 0)
                    {
                        result.Add(sequences[i]);
                    }
                }
                var sb = new StringBuilder();
                if (result.Count != 0&& result.Count > count)
                {
                    for (int j = 0; j < count; j++)
                    {
                        sb.AppendFormat("{0}, ", result[j]);
                    }
                }
               else
                {
                    for (int j = 0; j < result.Count; j++)
                    {
                        sb.AppendFormat("{0}, ", result[j]);
                    }
                }

                Console.WriteLine("[{0}]", sb.ToString().TrimEnd(',', ' '));

            }
            else
            {
                Console.WriteLine("Invalid count");
            }
        }
    }

    private static void ExecuteMinCommand(string commandArgument, List<string> sequences)
    {
        List<string> result = new List<string>();

        switch (commandArgument)
        {
            case "even":

                for (int i = 0; i < sequences.Count; i++)
                {
                    if (int.Parse(sequences[i]) % 2 == 0)
                    {
                        result.Add(sequences[i]);
                    }
                }
                if (result.Count != 0)
                {
                    var max = result.Min();
                    var indexOfMax = sequences.IndexOf(max);
                    //If there are two or more equal min/max elements, return the index of the rightmost one
                    Console.WriteLine(indexOfMax);
                }
                else
                {
                    Console.WriteLine("No matches");
                }

                break;
            case "odd":

                for (int i = 0; i < sequences.Count; i++)
                {
                    if (int.Parse(sequences[i]) % 2 != 0)
                    {
                        result.Add(sequences[i]);
                    }
                }
                if (result.Count != 0)
                {
                    var max = result.Min();
                    var indexOfMax = sequences.IndexOf(max);
                    //If there are two or more equal min/max elements, return the index of the rightmost one
                    Console.WriteLine(indexOfMax);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
                break;
        }
    }


    private static void ExecuteMaxCommand(string commandArgument, List<string> sequences)
    {
        List<string> result = new List<string>();

        switch (commandArgument)
        {
            case "even":

                for (int i = 0; i < sequences.Count; i++)
                {
                    if (int.Parse(sequences[i]) % 2 == 0)
                    {
                        result.Add(sequences[i]);
                    }
                }
                if (result.Count != 0)
                {
                    var max = result.Max();
                    var indexOfMax = sequences.IndexOf(max);
                    //If there are two or more equal min/max elements, return the index of the rightmost one
                    Console.WriteLine(indexOfMax);
                }
                else
                {
                    Console.WriteLine("No matches");
                }

                break;
            case "odd":

                for (int i = 0; i < sequences.Count; i++)
                {
                    if (int.Parse(sequences[i]) % 2 != 0)
                    {
                        result.Add(sequences[i]);
                    }
                }
                if (result.Count != 0)
                {
                    var max = result.Max();
                    var indexOfMax = sequences.IndexOf(max);
                    //If there are two or more equal min/max elements, return the index of the rightmost one
                    Console.WriteLine(indexOfMax);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
                break;
        }
    }
}

