using System;


class Program
{
    static void Main()
    {
        // Write a program that reads two integer numbers N and K and an array of N elements from the console.
        //Find the maximal sum of K elements in the array.

        int sizeOfArray = int.Parse(Console.ReadLine());
        int sequenceCount = int.Parse(Console.ReadLine());
        int[] digitHolder = new int[sizeOfArray];
        for (int i = 0; i < sizeOfArray; i++)
        {
            digitHolder[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(digitHolder);
        int sumOfSequence = 0;
        for (int i = sizeOfArray-1,j=0; j<sequenceCount; i--,j++)
        {
            sumOfSequence += digitHolder[i];
        }   
        Console.WriteLine(sumOfSequence);
    }
}

