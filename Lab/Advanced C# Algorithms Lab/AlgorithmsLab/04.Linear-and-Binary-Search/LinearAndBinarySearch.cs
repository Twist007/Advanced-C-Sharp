using System
using System.Linq;

class LinearAndBinarySearch
{
    static void Main()
    {
        int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int element = int.Parse(Console.ReadLine());

        Console.WriteLine(LinerSearch(num, element));
        Console.WriteLine(BinarySearch(num, element));


    }

    static int LinerSearch(int[] arr, int element)
    {
        int result = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == element)
            {
                result = i;
                break;
            }
        }

        return result;

    }

    static int BinarySearch(int[] arr, int element)
    {
        int result = -1;
        int min = 0;
        int max = arr.Length - 1;
        

        while (min<max)
        {
            int mid = (min + max) / 2;

            if (element == arr[mid] )
            {
                result = mid;
                if (arr[mid]==arr[min])
                {
                 return result = min;
                }
            }
            else if (element < arr[mid])
            {
                max = mid - 1;
            }
            else if (element > arr[mid])
            {
                min = mid + 1;
            }

        }

        return result;

    }
}

