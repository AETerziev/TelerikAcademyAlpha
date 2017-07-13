using System;
using System.Text;

class Program
{
    static void Main()
    {
        //Write a program that converts a string to a sequence of C# Unicode character literals.
        string input = Console.ReadLine();
        StringBuilder editedInput = new StringBuilder();
        editedInput.Append(input);
        foreach (char c in input)
        {
            editedInput.AppendFormat("\\u{0:X4}", (uint)c);
        }
        editedInput.Remove(0, input.Length);
        Console.WriteLine(editedInput.ToString());
    }


}

