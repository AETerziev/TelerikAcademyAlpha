using System;

class Program
{
    static void Main()
    {
        //Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there is no such element.
        int digitToLook = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string[] inputToArray = input.Split(' ');
        int[] inputToIntArray = Array.ConvertAll(inputToArray, int.Parse);
        Console.WriteLine(BiggerThanNeighbours(inputToIntArray));
    }

    static int BiggerThanNeighbours(int[] numberHolder)
    {
        bool isFound = false;
        int index= 0;
        for (int i = 0; i < numberHolder.Length; i++)
        {
            if (numberHolder.Length == 1)
            {
                break;
            }
            if (i == 0)
            {
                continue;
            }
            else if (i == numberHolder.Length - 1)
            {
                continue;
            }
            else if (numberHolder[i] > numberHolder[i + 1] && numberHolder[i] > numberHolder[i - 1])
            {
                index = i;
                isFound = true;
                break;
            }
        }
        if (isFound)
        {
            return index;
        }
        else
        {
            return -1;
        }
    }
}


