using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldFever
{
    class GoldFever
    {
        static void Main()
        {
            int daysCount = int.Parse(Console.ReadLine());
            int[] pricesArray = Console.ReadLine().Split().Select(n => Convert.ToInt32(n)).ToArray();
            int bestIndex = pricesArray.Length - 1;
            long result = 0;

            for (int i = pricesArray.Length - 2; i >= 0; i--)
            {
                if (pricesArray[i] <= pricesArray[bestIndex])
                {
                    result += pricesArray[bestIndex] - pricesArray[i];
                }

                else
                {
                    bestIndex = i;
                }
            }
            Console.WriteLine(result);
        }
    }
}


