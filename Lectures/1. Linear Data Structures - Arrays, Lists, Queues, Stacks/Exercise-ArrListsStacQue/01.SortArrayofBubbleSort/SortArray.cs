using System;
class SortArray
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int[] arr = new int[input.Length];

        int temp = int.MinValue;

        for (int i = 0; i < input.Length; i++)
        {
            arr[i] = int.Parse(input[i]);
        }

        for (int i = 0; i < arr.Length-1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                temp = arr[i + 1];
                arr[i + 1] = arr[i];
                arr[i] = temp;
            }
        }
        Console.WriteLine(string.Join(", ", arr));

    }
}

