using System;



class Program
{
    static void Main()
    {
        //Write a program that compares two char arrays lexicographically (letter by letter).

        string firstCharSequence = Console.ReadLine();
        string secondCharSequence = Console.ReadLine();
        char[] firstArray = firstCharSequence.ToCharArray();
        char[] secondArray = secondCharSequence.ToCharArray();
        bool areEqual = true;
        for (int i = 0; i < Math.Min(firstCharSequence.Length,secondCharSequence.Length); i++)
        {
            if (firstCharSequence[i]>secondCharSequence[i])
            {
                areEqual = false;
                Console.WriteLine(">");
                break;
            }
            else if(firstCharSequence[i]<secondCharSequence[i])
            {
                areEqual = false;
                Console.WriteLine("<");
                break;
            }
            else
            {
                continue;
            }
        }
        if (areEqual && firstCharSequence.Length>secondCharSequence.Length)
        {
            Console.WriteLine(">");
        }
        else if (areEqual && firstCharSequence.Length < secondCharSequence.Length)
        {
            Console.WriteLine("<");
        }
        else if (areEqual && firstCharSequence.Length == secondCharSequence.Length)
        {
            Console.WriteLine("=");
        }
    }
}

