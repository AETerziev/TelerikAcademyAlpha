using System;


class Program
{
    static void Main()
    {
        //Write a method that returns the last digit of given integer as an English word.
        // Write a program that reads a number and prints the result of the method.
        int input = int.Parse(Console.ReadLine());
        int lastDigit = (input % 10);
        Console.WriteLine(ReturnEnglishDigit(lastDigit));

    }

    static string ReturnEnglishDigit(int lastDigit)
    {
        if (lastDigit == 0)
        {
            return "zero";
        }
        else if (lastDigit == 1)
        {
            return "one";
        }
        else if (lastDigit == 2)
        {
            return "two";
        }
        else if (lastDigit == 3)
        {
            return "three";
        }
        else if (lastDigit == 4)
        {
            return "four";
        }
        else if (lastDigit == 5)
        {
            return "five";
        }
        else if (lastDigit == 6)
        {
            return "six";
        }
        else if (lastDigit == 7)
        {
            return "seven";
        }
        else if (lastDigit == 8)
        {
            return "eight";
        }
        else
        {
            return "nine";
        }

    }
}

