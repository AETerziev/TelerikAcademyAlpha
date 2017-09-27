using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace DSAExam
{
    public class Program
    {
        static void Main()
        {
            int commandCount = int.Parse(Console.ReadLine());
            string command;
            Dictionary<string, List<Order>> orders = new Dictionary<string, List<Order>>();
            Dictionary<string, List<int>> deletingOrders = new Dictionary<string, List<int>>();



            while (commandCount > 0)
            {
                command = Console.ReadLine();
                string[] commandArgs = command.Split(';'); 
                string[] commandStart = commandArgs[0].Split();
                switch (commandStart[0])
                {
                    case "AddOrder":
                        string product = String.Join(" ", commandStart);
                        product = product.Remove(0, 9);
                        decimal price = decimal.Parse(commandArgs[1]);
                        string consumer = commandArgs[2];
                        Order order = new Order(product, price, consumer);
                        if (!orders.ContainsKey(consumer))
                        {
                            orders.Add(consumer, new List<Order>());
                        }
                        if (!deletingOrders.ContainsKey(consumer))
                        {
                            deletingOrders.Add(consumer, new List<int>());

                        }
                        deletingOrders[consumer].Add(1);
                        orders[consumer].Add(order);
                        Console.WriteLine("Order added");
                        break;

                    case "FindOrdersByConsumer":
                        string consumerFind = commandStart[1];
                        List<Order> consumersToPrint = new List<Order>();
                        if (deletingOrders.ContainsKey(consumerFind))
                        {
                            foreach (var ord in orders[consumerFind])
                            {
                                consumersToPrint.Add(ord);
                            }
                        }
                        if (consumersToPrint.Count == 0)
                        {
                            Console.WriteLine("No orders found");
                        }
                        else
                        {
                            consumersToPrint.Sort();
                            foreach (var item in consumersToPrint)
                            {
                                Console.WriteLine(item);
                            }
                        }


                        break;



                    case "FindOrdersByPriceRange":
                        decimal startPrice = decimal.Parse(commandStart[1]);
                        decimal endPrice = decimal.Parse(commandArgs[1]);
                        List<Order> ordersToPrint = new List<Order>();


                        foreach (var key in orders)
                        {
                            if (deletingOrders.ContainsKey(key.Key))
                            {
                                foreach (var item in orders[key.Key])
                                {
                                    if (item.Price >= startPrice && item.Price <= endPrice)
                                    {
                                        ordersToPrint.Add(item);
                                    }
                                }
                            }
                        }

                        if (ordersToPrint.Count == 0)
                        {
                            Console.WriteLine("No orders found");
                        }
                        else
                        {
                            ordersToPrint.Sort();
                            foreach (var or in ordersToPrint)
                            {
                                Console.WriteLine(or);
                            }
                        }

                        break;

                    case "DeleteOrders":
                        string consumerToDelete = commandStart[1];
                        if (deletingOrders.ContainsKey(consumerToDelete))
                        {
                            int countOfOrders = deletingOrders[consumerToDelete].Count;
                            deletingOrders.Remove(consumerToDelete);
                            Console.WriteLine("{0} orders deleted", countOfOrders);
                        }
                        else
                        {
                            Console.WriteLine("No orders found");
                        }
                        break;

                    default:
                        break;
                }
                commandCount--;
            }
        }
    }







    public class Order : IComparable<Order>
    {
        public Order(string name, decimal price, string consumer)
        {
            this.Name = name;
            this.Price = price;
            this.Consumer = consumer;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Consumer { get; set; }


        public int CompareTo(Order other)
        {

            int result = this.Name.CompareTo(other.Name);

            return result;
        }

        public override string ToString()
        {
            return "{" + this.Name + ";" + this.Consumer + ";" + String.Format("{0:F2}", this.Price) + "}";
        }
    }
}
