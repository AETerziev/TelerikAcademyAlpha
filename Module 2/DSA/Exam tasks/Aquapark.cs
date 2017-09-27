using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK3
{
    class Program
    {
        static void Main()
        {
            int commandCount = int.Parse(Console.ReadLine());
            string command;
            Queue<int> que = new Queue<int>();
            Stack<int> stack = new Stack<int>();
         


            while (commandCount > 0)
            {
                command = Console.ReadLine();
                string[] commandArgs = command.Split();
                switch (commandArgs[0])
                {
                    case "add":
                        int person = int.Parse(commandArgs[1]);
                        que.Enqueue(person);
                        Console.WriteLine("Added {0}",person);
                        break;

                    case "slide":
                        int slides = int.Parse(commandArgs[1]);
                        for (int i = 0; i < slides; i++)
                        {
                            int current = que.Dequeue();
                            que.Enqueue(current);
                        }
                        Console.WriteLine("Slided {0}",slides);
                        break;

                    case "print":
                        int length = que.Count;
                        int[] all = new int[length];
                        for (int i = 0; i < length; i++)
                        {
                            all[i] = que.Dequeue();
                            que.Enqueue(all[i]);
                        }
                        Console.WriteLine(String.Join(" ",all.Reverse()));
                        break;

                    default:
                        break;
                }
                commandCount--;
            }
        }
    }
}
