using System;


class Program
{
    static void Main()
    {
        ReadNumber(1, 100);
    }



    static void ReadNumber(int start, int end)
    {
        int[] numbers = new int[10];
        try
        {
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    if (numbers[i] <= start)
                    {
                        throw new Exception();
                    }
                    continue;
                }
                else
                {
                    if (numbers[i] <= numbers[i - 1] || numbers[i] <= start || numbers[i] >= end)
                    {
                        throw new Exception();
                    }
                }
            }
            Console.Write("{0} < ", start); Console.Write(String.Join(" < ", numbers)); Console.Write(" < {0}", end);
        }


        catch (Exception)
        {

            Console.WriteLine("Exception");
        }
    }
}

