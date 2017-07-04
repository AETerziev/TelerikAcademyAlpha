using System;

    class Program
    {
        static void Main()
        {
        //Write a program that allocates array of N integers, initializes each element by its index multiplied by 5 and the prints the obtained array on the console.

        int sizeOfArray = int.Parse(Console.ReadLine());
        int[] arrayAllocator = new int[sizeOfArray];
        for (int i = 0; i < sizeOfArray; i++)
        {
            arrayAllocator[i] = (i * 5);
            Console.WriteLine(arrayAllocator[i]);
        }
        }
    }

