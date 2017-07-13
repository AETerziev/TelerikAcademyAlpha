using System;
using System.Text;

class Program
{
    static void Main()
    {
        //Write a program that replaces in a HTML document given as string all the tags <a href="URL">TEXT</a> with corresponding markdown notation [TEXT](URL).
        string inputToString = Console.ReadLine();
        StringBuilder newInput = new StringBuilder();
        StringBuilder url = new StringBuilder();
        StringBuilder text = new StringBuilder();
        bool isUrl = true;

        for (int j = 0, i = 1; j < inputToString.Length - 3; j++)
        {
            if (inputToString[j] == '<' && inputToString[j + 1] == 'a' && inputToString[j + 2] == ' ' && inputToString[j + 3] == 'h')
            {
                for (i = j + 9; inputToString[i] != '<' || inputToString[i + 1] != '/'; i++)
                {
                    if (inputToString[i] == '\"' && inputToString[i + 1] == '>')
                    {
                        isUrl = false;
                        i++;
                        continue;
                    }
                    if (isUrl)
                    {
                        url.Append(inputToString[i]);
                    }
                    else
                    {
                        text.Append(inputToString[i]);
                    }
                }
                newInput.Append("[" + text + "]" + "(" + url + ")");
                isUrl = true;
                url.Clear();
                text.Clear();
                j += (i - j + 3);
            }

            else
            {
                newInput.Append(inputToString[j]);
                continue;
            }
        }
        newInput.Append(inputToString[inputToString.Length - 3]);
        newInput.Append(inputToString[inputToString.Length - 2]);
        newInput.Append(inputToString[inputToString.Length - 1]);
        Console.WriteLine(newInput);

    }
}

