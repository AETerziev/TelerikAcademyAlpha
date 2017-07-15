using System;
using System.Linq;
using System.Numerics;


class Program
{
    static void Main()
    {
        //Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
        //Use variable number of arguments.
        //Write a program that reads 5 elements and prints their minimum, maximum, average, sum and product.
        string input = Console.ReadLine();
        int[] arrayOfNumbers = input.Split().Select(n => Convert.ToInt32(n)).ToArray();
        Console.WriteLine(MinimumOfNumbers(arrayOfNumbers));
        Console.WriteLine(MaximumOfNumbers(arrayOfNumbers));
        Console.WriteLine("{0:F2}",AverageOfNumbers(arrayOfNumbers));
        Console.WriteLine(SumOfNumbers(arrayOfNumbers));
        Console.WriteLine(ProductOfNumbers(arrayOfNumbers));
    }

    static int MinimumOfNumbers(int[] array)
    {
        Array.Sort(array);
        return array[0];
    }

    static int MaximumOfNumbers(int[] array)
    {
        Array.Sort(array);
        return array[array.Length - 1];
    }

    static int SumOfNumbers(int[] array)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            result += array[i];
        }
        return result;
    }

    static double AverageOfNumbers(int[] array)
    {
        double sum = (double)SumOfNumbers(array);
        return sum / array.Length;
    }

    static BigInteger ProductOfNumbers(int[] array)
    {
        BigInteger result = 1;
        for (int i = 0; i < array.Length; i++)
        {
            result *= array[i];
        }
        return result;
    }
}

