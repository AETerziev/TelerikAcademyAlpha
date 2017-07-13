using System;


class Program
{
    static void Main()
    {
        //Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
        string urlInput = Console.ReadLine();
        for (int i = 0; i < urlInput.Length; i++)
        {
            if (urlInput[i]==':')
            {
                Console.WriteLine("[protocol] = {0}",urlInput.Substring(0,i));
                urlInput=urlInput.Remove(0, i + 3);
            }
            if (urlInput[i]=='.')
            {
                while (urlInput[i]!='/')
                {
                    i++;
                }
                Console.WriteLine("[server] = {0}",urlInput.Substring(0,i));
                Console.WriteLine("[resource] = {0}",urlInput.Substring(i,urlInput.Length-(i)));
                break;
            }

        }
    }
}

