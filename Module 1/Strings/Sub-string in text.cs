using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        //Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
        string sequenceToLookFor = Console.ReadLine().ToUpper();
        string textToLookInto = Console.ReadLine().ToUpper();
        string tempString = textToLookInto.Replace(sequenceToLookFor, "");
        Console.WriteLine((textToLookInto.Length - tempString.Length) / sequenceToLookFor.Length);

    }
}
