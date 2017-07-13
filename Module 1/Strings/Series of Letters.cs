using System;
using System.Text;

class Program
{
    static void Main()
    {
        //Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
        string input = Console.ReadLine();
        StringBuilder editedInput = new StringBuilder();
        for (int i = 0; i < input.Length-1; i++)
        {
            if (i != input.Length - 1 && input[i]==input[i+1])
            {
                continue;
            }
            else
            {
                editedInput.Append(input[i]);
            }
        }
        if (editedInput[editedInput.Length-1]!=input[input.Length-1])
        {
            editedInput.Append(input[input.Length - 1]);
        }
        Console.WriteLine(editedInput);
    }
}

