using System;
using System.Globalization;


class Program
{
    static void Main()
    {
        try
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            double input = double.Parse(Console.ReadLine());
            if (input < 0)
            {
                throw new FormatException();

            }
            Console.WriteLine("{0:F3}", Math.Sqrt(input));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");

        }
        finally
        {
            Console.WriteLine("Good bye");
        }

    }
}

