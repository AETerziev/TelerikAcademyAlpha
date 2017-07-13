using System;

class Program
{
    //Write a program to check if in a given expression the ( and ) brackets are put correctly.
    static void Main()
    {
        string input = Console.ReadLine();
        bool isCorrect = true;
        int leftBracketCounter = 0;
        int rightBracketCounter = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                leftBracketCounter++;
            }
            if (input[i] == ')')
            {
                rightBracketCounter++;
            }
        }
        if (leftBracketCounter != rightBracketCounter || input.IndexOf('(') > input.IndexOf(')'))
        {
            isCorrect = false;
        }
        if (isCorrect)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}


