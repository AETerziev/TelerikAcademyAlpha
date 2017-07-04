using System;



class Program
{
    static void Main()
    {
        //Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
        //Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

        int sizeOfArray = int.Parse(Console.ReadLine());
        double[] arrayToSort = new double[sizeOfArray];
        for (int i = 0; i < sizeOfArray; i++)
        {
            arrayToSort[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < sizeOfArray-1; i++)
        {
            double currentMin = arrayToSort[i];
            int currentMinIndex = i;
            for (int j = i+1; j < sizeOfArray; j++)
            {
                if (currentMin>arrayToSort[j])
                {
                    currentMin = arrayToSort[j];
                    currentMinIndex = j;

                }
            }
            if (currentMinIndex!=i)
            {
                arrayToSort[currentMinIndex] = arrayToSort[i];
                arrayToSort[i] = currentMin;
            }
        }

        for (int i = 0; i < sizeOfArray; i++)
        {
            Console.WriteLine(arrayToSort[i]);
        }
    }
}

