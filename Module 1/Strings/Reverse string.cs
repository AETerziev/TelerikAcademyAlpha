using System;

class Program
{
    static void Main()
    {
        //Write a program that reads a string, reverses it and prints the result on the console.
        string input = Console.ReadLine();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write(input[i]);
        }
    }
}

