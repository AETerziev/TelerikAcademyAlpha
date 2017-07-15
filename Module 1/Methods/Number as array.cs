using System;
using System.Text;
using System.Numerics;
using System.Linq;


class Program
{
    static void Main()
    {
        string sizeOfMatrix = Console.ReadLine();
        string firstArray = Console.ReadLine();
        string secondArray = Console.ReadLine();
        string[] firstToString = firstArray.Split();
        string[] secondToString = secondArray.Split();
        string output = SumOfArrays(firstToString, secondToString);

        for (int i = output.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                Console.Write(output[i]);
            }
            else
            {
                Console.Write(output[i] + " ");
            }
        }
    }

    static string SumOfArrays(string[] firstArray, string[] secondAArray)

    {
        bool st = true;
        Array.Reverse(firstArray);
        Array.Reverse(secondAArray);
        string firstArrayAsString = String.Join("", firstArray);
        string secondArrayAsString = String.Join("", secondAArray);
        int[] firstInt = firstArrayAsString.Select(ch => ch - '0').ToArray();
        int[] secondInt = secondArrayAsString.Select(ch => ch - '0').ToArray();
        BigInteger finalFirst = BigInteger.Parse(firstArrayAsString);
        BigInteger finalSecond = BigInteger.Parse(secondArrayAsString);
        finalFirst += finalSecond;
        char[] final = finalFirst.ToString().ToCharArray();
        Array.Reverse(final);

        return 1.ToString();
    }
}

