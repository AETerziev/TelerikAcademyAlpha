using System;


class Program
{
    static void Main()
    {
        //Write a method that counts how many times given number appears in a given array.
        //Write a test program to check if the method is working correctly.
        int sizeOfArray = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string[] inputToArray = input.Split();
        int digitToLook = int.Parse(Console.ReadLine());
        Console.WriteLine(CountOfDigit(digitToLook, inputToArray));
    }

    static int CountOfDigit(int digit, string[] numberHolder)
    {
        int counter = 0;
        for (int i = 0; i < numberHolder.Length; i++)
        {
            if (numberHolder[i].Contains(digit.ToString()))
            {
                counter++;
            }
        }
        return counter;
    }
}

