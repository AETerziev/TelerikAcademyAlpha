using System;


class Program
{
    static void Main()
    {
        //Write a program that finds the most frequent number in an array of N elements.

        int sizeOfArray = int.Parse(Console.ReadLine());
        double[] digitHolder = new double[sizeOfArray];
        for (int i = 0; i < sizeOfArray; i++)
        {
            digitHolder[i] = double.Parse(Console.ReadLine());
        }
        double digitOfLongestSequence = digitHolder[sizeOfArray-1];
        Array.Sort(digitHolder);
        int currentSequence = 1;
        int longestSequence = 1;
        for (int i = 1; i < sizeOfArray; i++)
        {
            if(digitHolder[i]==digitHolder[i-1])
            {
                currentSequence++;
            }
            else
            {
                if (currentSequence>longestSequence)
                {
                    longestSequence = currentSequence;
                    currentSequence = 1;
                    digitOfLongestSequence = digitHolder[i - 1];
                }
                else
                {
                    currentSequence = 1;
                }
            }
        } 
        Console.WriteLine("{0} ({1} times)",digitOfLongestSequence,longestSequence);
    }
}

