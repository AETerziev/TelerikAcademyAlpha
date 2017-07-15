using System;


class Program
{
    static void Main()
    {
        //Write a method GetMax() with two parameters that returns the larger of two integers.
        //Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
        string[] input = Console.ReadLine().Split();
        int firstNumber = Int32.Parse(input[0]);
        int secondNumber = Int32.Parse(input[1]);
        int thirdNumber = Int32.Parse(input[2]);
        Console.WriteLine(GetMax(GetMax(firstNumber, secondNumber), thirdNumber));

    }

    static int GetMax(int firstNumber, int secondNumber)
    {
        return firstNumber > secondNumber ? firstNumber : secondNumber;
    }
}

