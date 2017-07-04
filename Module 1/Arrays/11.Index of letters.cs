using System;


class Program
{
    static void Main()
    {
        //Write a program that creates an array containing all letters from the alphabet (a-z).
       //Read a word from the console and print the index of each of its letters in the array.
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        string wordToWorkWith = Console.ReadLine();
        for (int i = 0; i < wordToWorkWith.Length; i++)
        {
            Console.WriteLine(Array.BinarySearch(alphabet,wordToWorkWith[i]));
        }
    }
}

