using System;



class Program
{
    static void Main()
    {
        //Write a program that reads two integer arrays of size N from the console and compares them element by element.

        int sizeOfArray = int.Parse(Console.ReadLine());
        int[] firstArray = new int[sizeOfArray];
        int[] secondArray = new int[sizeOfArray];
        bool areEqual = true;
        for (int i = 0; i < sizeOfArray; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < sizeOfArray; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
            if (secondArray[i] != firstArray[i])
            {
                areEqual = false;
            }
        }
        Console.WriteLine(areEqual?"Equal":"Not equal");
    }
}

