using System;

class Program
{
    static void Main()
    {
        //Write a method that asks the user for his name and prints Hello, <name>!.
        //Write a program to test this method.
        string name = Console.ReadLine();
        Console.WriteLine(SayHello(name));
    }

    static string SayHello(string name)
    {
        return "Hello, " + name + "!";
    }
}

