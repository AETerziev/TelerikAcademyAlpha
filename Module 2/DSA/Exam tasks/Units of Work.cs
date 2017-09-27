using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace UnitsOfWorkLegit
{
    public class UnitsOfWork
    {
        static void Main()
        {
            string command;
            Dictionary<string, OrderedSet<Unit>> units = new Dictionary<string, OrderedSet<Unit>>();
            Dictionary<string,string> namesTaken = new Dictionary<string, string>();
            OrderedSet<Unit> powerUnits = new OrderedSet<Unit>();
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split().ToArray();
                switch (commandArgs[0])
                {
                    case "add":
                        string name = commandArgs[1];
                        string type = commandArgs[2];
                        int attack = int.Parse(commandArgs[3]);
                        if (namesTaken.ContainsKey(name))
                        {
                            Console.WriteLine("FAIL: {0} already exists!", name);
                            break;
                        }
                        else
                        {
                            namesTaken.Add(name,type);
                            powerUnits.Add(new Unit(name, type, attack));
                        }


                        if (!units.ContainsKey(type))
                        {
                            units.Add(type, new OrderedSet<Unit>());
                            units[type].Add(new Unit(name, type, attack));
                            Console.WriteLine("SUCCESS: {0} added!", name);
                        }
                        else
                        {
                            units[type].Add(new Unit(name, type, attack));
                            Console.WriteLine("SUCCESS: {0} added!", name);
                        }
                        break;

                    case "remove":
                        string removeName = commandArgs[1];
                        if (!namesTaken.ContainsKey(removeName))
                        {
                            Console.WriteLine("FAIL: {0} could not be found!",removeName);
                        }
                        else
                        {
                            Console.WriteLine("SUCCESS: {0} removed!",removeName);
                            namesTaken.Remove(removeName);
                        }
                        break;

                    case "find":
                        string findType = commandArgs[1];
                        if (units.ContainsKey(findType))
                        {
                            Console.WriteLine("RESULT: {0}", String.Join(", ", units[findType].Where(x => namesTaken.ContainsKey(x.Name)).Take(10)));

                        }
                        else
                        {
                            Console.WriteLine("RESULT:");
                        }
                        break;

                    case "power":
                        int unitsCount = int.Parse(commandArgs[1]);
                        Console.WriteLine("RESULT: {0}", String.Join(", ",powerUnits.Where(x => namesTaken.ContainsKey(x.Name)).Take(unitsCount)));
                        // Needs check in namesTaken for remove etc.
                        break;


                    default:
                        break;
                }
            }

        }
    }


    public class Unit:IComparable<Unit>
    {
        public Unit(string name, string type, int attack)
        {
            this.Name = name;
            this.Type = type;
            this.Attack = attack;
        }

        public string Name { get; set; } //unique
        public string Type { get; set; } //not unique
        public int Attack { get; set; }

        public int CompareTo(Unit other)
        {
            int result = this.Attack.CompareTo(other.Attack)* -1;
            if (result==0)
            {
                result = this.Name.CompareTo(other.Name);
            }
            return result;
        }

        public override string ToString()
        {
            return this.Name + "[" + this.Type + "]" + "(" + this.Attack.ToString() + ")";
        }
    }
}
