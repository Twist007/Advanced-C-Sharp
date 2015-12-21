//Write a program that takes a text and a string of banned words. All words included in the ban list should be replaced with asterisks "*", equal to the word's length. The entries in the ban list will be separated by a comma and space ", ". The ban list should be entered on the first input line and the text on the second input line

using System;
using System.Linq;
using System.Text;
class TextFilter
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(new char[] { ',', ' ', }, StringSplitOptions.RemoveEmptyEntries);
        string text = Console.ReadLine();
        
        StringBuilder sbText = new StringBuilder(text);
        
            sbText.Replace(words[0], new string('*', words[0].Length));
            sbText.Replace(words[1], new string('*', words[1].Length));

        Console.WriteLine();
        Console.WriteLine(sbText);
        
    }

}


