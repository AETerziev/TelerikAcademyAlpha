using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentation
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            char[] forbiddenChars = @" ,.!?".ToCharArray();
            string clean = new string(input.Where(c => !forbiddenChars.Contains(c)).ToArray());
            StringBuilder text = new StringBuilder();
            text.Append(clean);
            int actionCounter = 0;
            for (int i = 0, j = text.Length - 1; i < text.Length / 2; i++, j--)
            {
                if (text[i] == text[j])
                {
                    continue;
                }
                else
                {
                    while (text[i] != text[j])
                    {
                        if (text[i] < text[j] && (('z' - text[j]) + (text[i] - 'a')) < text[j] - text[i])
                        {
                            if (text[i] == 'a')
                            {
                                text[i] = 'z';
                            }
                            else
                            {
                                text[i]++;
                            }
                        }
                        else if (text[i] < text[j] && (('z' - text[j]) + (text[i] - 'a')) > text[j] - text[i])
                        {
                            if (text[i] == 'z')
                            {
                                text[i] = 'a';
                            }
                            else
                            {
                                text[i]++;
                            }
                        }
                        else if (text[i] > text[j] && text[i] - text[j] > ('z' - text[i] + text[j] - 'a'))
                        {
                            if (text[i] == 'z')
                            {
                                text[i] = 'a';
                            }
                            else
                            {
                                text[i]++;

                            }
                        }
                        else if (text[i] > text[j] && text[i] - text[j] < ('z' - text[i] + text[j] - 'a'))
                        {
                            text[i]--;
                        }
                        actionCounter++;
                    }
                }
            }
            Console.WriteLine(actionCounter);
        }
    }
}
