using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfWork
{
    class Program
    {
        static void Main()
        {
            int[] inputArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int peopleCount = inputArgs[0];
            int pairCount = inputArgs[1];
            Dictionary<int, HashSet<int>> graph = new Dictionary<int, HashSet<int>>();
            bool[] visited = new bool[inputArgs[0]];
            for (int i = 0; i < pairCount; i++)
            {
                int[] pair = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int first = pair[0];
                int second = pair[1];

                if (!graph.ContainsKey(first))
                {
                    graph.Add(first, new HashSet<int>());
                }

                if (!graph.ContainsKey(second))
                {
                    graph.Add(second, new HashSet<int>());
                }
                graph[first].Add(second);
                graph[second].Add(first);
            }
            long result = 0;
            long singles = peopleCount - graph.Keys.Count;
            List<int> companiesPeopleCount = new List<int>();
            foreach (var key in graph.Keys)
            {
                if (!visited[key])
                {
                    companiesPeopleCount.Add(DFS(key, graph, visited));
                }
            }

            for (int i = 0; i < companiesPeopleCount.Count-1; i++)
            {
                result += companiesPeopleCount[i] * singles;
                for (int j = i+1; j < companiesPeopleCount.Count; j++)
                {
                    result += companiesPeopleCount[i] * companiesPeopleCount[j];
                }
            }

            if (singles>0)
            {
                result+=companiesPeopleCount[companiesPeopleCount.Count - 1] * singles;
                result += (singles * (singles - 1)) / 2;
            }       

            Console.WriteLine(result);
        }



        public static int DFS(int start, Dictionary<int, HashSet<int>> graph, bool[] visited)
        {
            int result = 0;
            if (visited[start])
            {
                return result;
            }
            result++;
            visited[start] = true;
            var successors = graph[start];
            foreach (var succ in successors)
            {
                result += DFS(succ, graph, visited);
            }
            return result;

        }
    }
}
