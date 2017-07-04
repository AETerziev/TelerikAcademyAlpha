using System;


class Program
{
    static void Main()
    {
        //Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.
        // Can you do it with only one loop (with single scan through the elements of the array)?

        int sizeOfArray = int.Parse(Console.ReadLine());
        int[] digitHolder = new int[sizeOfArray];
        for (int i = 0; i < sizeOfArray; i++)
        {
            digitHolder[i] = int.Parse(Console.ReadLine());
        }
        int currentSum = digitHolder[0];
        int maxSum = digitHolder[0];
        int startIndex = 0;
        int endIndex = 0;
        int currentStartIndex = 0;


        for (int i = 1; i < sizeOfArray; i++)
        {
            if (currentSum < 0)
            {
                currentSum = digitHolder[i];
                currentStartIndex = i;
            }
            else
            {
                currentSum += digitHolder[i];
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                startIndex = currentStartIndex;
                endIndex = i;
            }
        }
        Console.WriteLine(maxSum);

        //Kadane's Algorithm has been used, after fully understanding of how it works.
    }
}

