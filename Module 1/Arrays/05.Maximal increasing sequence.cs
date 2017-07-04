using System;

class Program
{
    static void Main()
    {
        //Write a program that finds the length of the maximal increasing sequence in an array of N integers.

        int digitCount = int.Parse(Console.ReadLine());
        int[] digitHolder = new int[digitCount];
        int bestSequence = 1;
        int currentSequence = 1;
        for (int i = 0; i < digitCount; i++)
        {
            digitHolder[i] = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                continue;
            }
            if (digitHolder[i] > (digitHolder[i - 1]))
            {
                currentSequence += 1;

                if (bestSequence < currentSequence)
                {
                    bestSequence = currentSequence;
                }
            }
            else
            {
                currentSequence = 1;
            }

        }
        Console.WriteLine(bestSequence);

    }
}
