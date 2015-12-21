using System;
class LastDigitOfNumber
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(GetLastDigitAsWord(input));
    }

    static string GetLastDigitAsWord(int number)
    {

        int lastDigit = number % 10;
        string numberAsWord = "";
        switch (lastDigit)
        {
            case 0:
                numberAsWord = "zero";
                break;
            case 1:
                numberAsWord = "one";
                break;
            case 2:
                numberAsWord = "two";
                break;
            case 3:
                numberAsWord = "three";
                break;
            case 4:
                numberAsWord = "four";
                break;
            case 5:
                numberAsWord = "five";
                break;
            case 6:
                numberAsWord = "six";
                break;
            case 7:
                numberAsWord = "seven";
                break;
            case 8:
                numberAsWord = "eight";
                break;
            case 9:
                numberAsWord = "nine";
                break;

            default:
                numberAsWord = "Invalid input!";
                break;
        }

        return numberAsWord;


    }
}

