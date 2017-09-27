using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace OfficeSpace
{
    public class Program
    {
        static void Main()
        {
            //Need to know the parents of every node
            //For each node takes the longest path and compares it to all of tge rest
            //parents are most important
            int taskCount = int.Parse(Console.ReadLine());
            int[] tasks = Console.ReadLine().Split().Select(str => int.Parse(str)).ToArray();
            SortedDictionary<Task, SortedSet<Task>> taskCollection = new SortedDictionary<Task, SortedSet<Task>>();
            for (int i = 0; i < tasks.Length; i++)
            {
                taskCollection.Add(new T, new SortedSet<int>());
                int[] currentDependingTasks= Console.ReadLine().Split().Select(str => int.Parse(str)).ToArray();
                if (currentDependingTasks[0]==0)
                {
                    continue;
                }

                for (int j = 0; j < currentDependingTasks.Length; j++)
                {
                    taskCollection[tasks[i]].Add(currentDependingTasks[j]);
                }
            }



        }
    }




    public class Task:IComparable<Task>
    {

        public Task(int time)
        {
            this.Time = time;
        }

        int Time { get; set; }




        public int CompareTo(Task other)
        {
            return this.Time.CompareTo(other.Time);
        }
    }
}
