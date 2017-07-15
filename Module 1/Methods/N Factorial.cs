using System;
using System.Numerics;


class Program
{
    static void Main()
    {
        //Write a method that multiplies a number represented as an array of digits by a given integer number.
        //Write a program to calculate N!.
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        BigInteger factorialOfNumber = Factorial(number);
        Console.WriteLine(factorialOfNumber);
    }


    static BigInteger Factorial(BigInteger number)
    {
        if (number == 0)
        {
            return 1;
        }
        else
        {
            return number * Factorial(number - 1);
        }
    }
}
