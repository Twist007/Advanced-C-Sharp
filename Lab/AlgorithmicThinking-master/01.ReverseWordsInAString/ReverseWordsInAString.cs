namespace _01.ReverseWordsInAString
{
    using System;

    class ReverseWordsInAString
    {
        static void Main()
        {
            // Sample input: "You with be force the may" ;)
            Console.Write("Insert text = ");
            string[] text = Console.ReadLine()
                .ToLower()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < text.Length / 2; i++)
            {
                Swap(ref text[i], ref text[text.Length - 1 - i]);
            }

            text[0] = char.ToUpper(text[0][0]) + text[0].Substring(1);
            Console.WriteLine(string.Join(" ", text));
        }

        private static void Swap(ref string left, ref string right)
        {
            string temp = left;
            left = right;
            right = temp;
        }
    }
}