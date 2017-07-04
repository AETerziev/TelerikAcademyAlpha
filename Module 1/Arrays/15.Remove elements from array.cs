using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] digitHolder = new int[n];
        for (int i = 0; i <= digitHolder.Length - 1; i++)
        {
            digitHolder[i] = int.Parse(Console.ReadLine());
        }

        int[] secondDigitHOLDE = new int[n]; 
        for (int i = 0; i <= LIS.Length - 1; i++)
        {
            LIS[i] = 1;
        }
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if ((digitHolder[i] >= digitHolder[j]) && (LIS[j] >= LIS[i]))
                {
                    LIS[i] = LIS[j] + 1;
                }
            }
        }
        //print
        Array.Sort(LIS);
        int printResult = n - LIS[LIS.Length - 1];
        Console.WriteLine(printResult);
    }
}

