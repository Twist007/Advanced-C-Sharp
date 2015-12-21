using System;
using System.Linq;
public class SelectionSort
{
    public static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); // Read in integers.
        for (int i = 0; i < arr.Length; i++)
        {
            int min = arr[i];
            for (int j = i + 1; j < arr.Length; j++)
            {
                min = Math.Min(min, arr[j]); // Compare element i with the following elements.
            }
            arr[Array.IndexOf(arr, min)] = arr[i]; // Swap the values of min element and element i.
            arr[i] = min;
        }
        Console.WriteLine(string.Join(" ", arr));
    }
}