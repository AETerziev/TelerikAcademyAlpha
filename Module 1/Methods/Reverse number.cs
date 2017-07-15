using System;
using System.Text;

class Program
{
    static void Main()
    {
        //Write a method that reverses the digits of a given decimal number.
        string input = Console.ReadLine();
        Console.WriteLine(ReverseNumber(input));

    }


    static string ReverseNumber(string input)
    {
        StringBuilder reversedString = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversedString.Append(input[i]);
        }
        return reversedString.ToString();
    }
}

