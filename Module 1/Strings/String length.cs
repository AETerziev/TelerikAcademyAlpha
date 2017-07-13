using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
        StringBuilder input = new StringBuilder(Console.ReadLine());
        while (input.Length<20)
        {
            input.Append("*");
        }
        Console.WriteLine(input);
    }
}

