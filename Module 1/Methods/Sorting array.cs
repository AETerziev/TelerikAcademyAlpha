using System;
using System.Linq;


class Program
{
    static void Main()
    {
        //Write a method that returns the maximal element in a portion of array of integers starting at given index.
       // Using it write another method that sorts an array in ascending / descending order.
        //Write a program that sorts a given array.
        int sizeOfArray = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int[] numberHolder = input.Split().Select(n => Convert.ToInt32(n)).ToArray();
        Console.WriteLine(SortArray(numberHolder));

    }

    static int MaximalElement(int[] numberHolder, int index)
    {
        int bestElement = numberHolder[index];
        for (int i = index+1; i < numberHolder.Length; i++)
        {
            if (numberHolder[i]>numberHolder[i-1])
            {
                bestElement = numberHolder[i];
            }
        }
        return bestElement;
    }
    static string SortArray(int[] numberHolder)
    {
        Array.Sort(numberHolder);
        return string.Join(" ", numberHolder);
    }
}

