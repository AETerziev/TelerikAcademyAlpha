using System;
using System.Text;

class Program
{
    static void Main()
    {
        //You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
        string input = Console.ReadLine();
        StringBuilder parser=new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            parser.Append(input[i]);
        }
        for (int i = 0; i < input.Length; i++)
        {
            if (parser[i]=='>')
            {
                i++;
                while (parser[i] !='>')
                {
                    parser[i] = Char.ToUpper(parser[i]);
                    i++;
                }
            }
        }
        parser.Replace("<upcase>", "");
        parser.Replace("</UPCASE>", "");
        Console.WriteLine(parser);
    }
}

