using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;

class Program
{

    static void Main()
    {
        //Write a program that extracts from a given text all sentences containing given word.
        string wordToLookFor = Console.ReadLine();
        string input = Console.ReadLine();
        List<string> list = new List<string>();
        StringBuilder editedInput = new StringBuilder();
        editedInput.Append(input);
        for (int i = 0; i < editedInput.Length; i++)
        {
            if (editedInput[i] != '.' && (editedInput[i] < 'a' || editedInput[i] > 'z') && (editedInput[i] < 'A' || editedInput[i] > 'Z'))
            {

                editedInput.Replace(editedInput[i], ' ', i, 1);
            }
        }
        string newInput = editedInput.ToString();

        for (int i = 0, letterCount = 0, tempIndex = 0; i < input.Length; i++)
        {
            letterCount++;
            if (input[i] == '.')
            {
                string[] splitWords = newInput.Substring(tempIndex, letterCount-1).Split();
                foreach (var item in splitWords)
                {
                    item.Trim();
                    if (item==wordToLookFor)
                    {
                        list.Add(input.Substring(tempIndex, letterCount).Trim());
                        break;
                    }
                }
                letterCount = 0;
                tempIndex = i + 1;
            }
        }
        Console.WriteLine(String.Join(" ",list));
    }
}
