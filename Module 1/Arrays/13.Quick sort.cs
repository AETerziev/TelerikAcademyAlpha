using System;

class Program
{
    static void Main()
    {
        //This solution does not belong to me. It is taken and learned from http://telerikacademy.com/Forum/Questions/164986/CSharp-Part-2-Arrays-Homework-Problem-14-Quick-Sort URL
        // user:Neutrino
        int sizeOfArray = int.Parse(Console.ReadLine());
        int[] numbers = new int[sizeOfArray];
        for (int i = 0; i < sizeOfArray; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        QuickSort(numbers, 0, numbers.Length - 1);
        for (int i = 0; i < sizeOfArray; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    static void QuickSort(int[] numbers, int start, int end)
    {
        if (start < end)
        {
            int pivot = numbers[end];
            int pIndex = start;
            for (int i = start; i < end; i++)
            {
                if (numbers[i] <= pivot) // swap
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[pIndex];
                    numbers[pIndex] = temp;

                    pIndex++;
                }
            }

            numbers[end] = numbers[pIndex];
            numbers[pIndex] = pivot;

            QuickSort(numbers, start, pIndex - 1);
            QuickSort(numbers, pIndex + 1, end);
        }
    }
}

