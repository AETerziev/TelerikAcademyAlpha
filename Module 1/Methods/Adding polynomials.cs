using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //Write a method that adds two polynomials.Represent them as arrays of their coefficients.
        //Write a program that reads two polynomials and prints their sum.
        int sizeOfPoly = int.Parse(Console.ReadLine());
        string firstPoly = Console.ReadLine();
        string secondPoly = Console.ReadLine();
        int[] firstArray = firstPoly.Split().Select(n => Convert.ToInt32(n)).ToArray();
        int[] secondArray = secondPoly.Split().Select(n => Convert.ToInt32(n)).ToArray();
        int[] result = SumPolyCoef(firstArray, secondArray);
        Console.WriteLine(String.Join(" ",result));



    }

    static int[] SumPolyCoef(int[] firstArray, int[] secondArray)
    {
        int[] result = new int[firstArray.Length];
        for (int i = 0; i < firstArray.Length; i++)
        {
            result[i] = firstArray[i] + secondArray[i];
        }
        return result;
    }
}

