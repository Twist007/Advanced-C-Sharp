
using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class LittleJohn
{
    static void Main()
    {
        StringBuilder strBuilder = new StringBuilder();

        for (int i = 0; i < 4; i++)
        {
            strBuilder.AppendFormat(" {0}", Console.ReadLine());
        }

        const string arrowPattern = @"(>>>----->>)|(>>----->)|(>----->)";
        Regex arrowMatcher = new Regex(arrowPattern);

        var arrows = arrowMatcher.Matches(strBuilder.ToString());

        int largeArrowCount = 0;
        int mediumArrowCount = 0;
        int smallArrowCount = 0;

        foreach (Match arrow in arrows)
        {
            if (!string.IsNullOrEmpty(arrow.Groups[1].Value))
            {
                largeArrowCount++;
            }
            else if (!string.IsNullOrEmpty(arrow.Groups[2].Value))
            {
                mediumArrowCount++;
            }
            else
            {
                smallArrowCount++;
            }
        }

        string numbersAsString = string.Format("{0}{1}{2}", smallArrowCount, mediumArrowCount, largeArrowCount);

        long numberLong = long.Parse(numbersAsString);

        string binaryNum = Convert.ToString(numberLong, 2);

        string reversed = new string(binaryNum.Reverse().ToArray());
        string resultAString = binaryNum + reversed;
        long result = Convert.ToInt64(resultAString, 2);

        Console.WriteLine(result);

    }
}

