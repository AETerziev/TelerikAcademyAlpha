using System;


class Program
{
    static void Main()
    {
        //Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
        // Write program that reads an array of numbers and prints how many of them are larger than their neighbours.
        int digitToLook = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string[] inputToArray = input.Split(' ');
        int[] inputToIntArray = Array.ConvertAll(inputToArray, int.Parse);
        Console.WriteLine(BiggerThanNeighbours(inputToIntArray));
    }

    static int BiggerThanNeighbours(int[] numberHolder)
    {
        int counter = 0;
        for (int i = 0; i < numberHolder.Length; i++)
        {
            if (numberHolder.Length ==1)
            {
                break;
            }
            if (i==0)
            {
                continue;
            }
            else if (i==numberHolder.Length-1)
            {
                continue;
            }
            else if (numberHolder[i]>numberHolder[i+1] && numberHolder[i]>numberHolder[i-1])
            {
                counter++;
            }
        }
        return counter;
    }
}
