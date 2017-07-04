using System;


class Program
{
    static void Main()
    {
        //Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.
        int sizeOfArray = int.Parse(Console.ReadLine());
        int[] numberHolder = new int[sizeOfArray];
        for (int i = 0; i < sizeOfArray; i++)
        {
            numberHolder[i] = int.Parse(Console.ReadLine());
        }
        int numberToLookFor = int.Parse(Console.ReadLine());
        Array.Sort(numberHolder);
        if (Array.BinarySearch(numberHolder, numberToLookFor) < 0)
        {
            Console.WriteLine("-1");
        }
        else
        {
            Console.WriteLine(Array.BinarySearch(numberHolder, numberToLookFor));
        }
        
    }
}

