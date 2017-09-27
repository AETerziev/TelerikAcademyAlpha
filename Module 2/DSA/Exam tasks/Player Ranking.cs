using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Wintellect.PowerCollections;

namespace PlayerRanking
{
    public class Program
    {
        static void Main()
        {
            string command;
            BigList<Player> rankingList = new BigList<Player>();
            Dictionary<string, OrderedSet<Player>> typeToPlayerMap = new Dictionary<string, OrderedSet<Player>>();
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split();
                switch (commandArgs[0])
                {
                    case "add":
                        string name = commandArgs[1];
                        string type = commandArgs[2];
                        int age = int.Parse(commandArgs[3]);
                        int position = int.Parse(commandArgs[4]) - 1;
                        Player player = new Player(name, type, age, position);

                        if (!typeToPlayerMap.ContainsKey(type))
                        {
                            typeToPlayerMap.Add(type, new OrderedSet<Player>());
                        }
                        typeToPlayerMap[type].Add(player);
                        rankingList.Insert(position, player);
                        Console.WriteLine("Added player {0} to position {1}",player.Name,position+1);
                        break;

                    case "find":
                        string findType = commandArgs[1];
                        if (typeToPlayerMap.ContainsKey(findType))
                        {
                            var players = typeToPlayerMap[findType];
                            Console.WriteLine("Type {0}: {1}", findType, String.Join("; ", players.Take(5)).TrimEnd(';', ' '));
                        }
                        else
                        {
                            Console.WriteLine(String.Format("Type {0}: ",findType));
                        }
                            break;

                    case "ranklist":
                        int start = int.Parse(commandArgs[1])-1;
                        int end = int.Parse(commandArgs[2])-1;
                        int count = end - start + 1;
                        var rankedPlayers = rankingList.Range(start, count);
                        int playerPosition = start +1;
                        string result = String.Join("; ", rankedPlayers.Select(p => String.Format("{0}. {1}",playerPosition++,p.ToString())));
                        result.TrimEnd(';', ' ');
                        Console.WriteLine(result);
                        break;


                    default:
                        break;
                }
            }




        }
    }

    public class Player : IComparable<Player>
    {

        public Player(string name, string type, int age, int position)
        {
            this.Name = name;
            this.Type = type;
            this.Age = age;
            this.Position = position;
        }

        public string Name { get; set; }
        string Type { get; set; }
        public int Age { get; set; }
        public int Position { get; set; }

        public int CompareTo(Player other)
        {
            int result = this.Name.CompareTo(other.Name);
            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age) * -1; //Need to be the other way around!
            }
            return result;
        }

        public override string ToString()
        {
            return this.Name + "(" + this.Age + ")";
        }
    }

    public enum PlayerType
    {
        Aggressive,
        Neutral,
        Defensive
    }

}
