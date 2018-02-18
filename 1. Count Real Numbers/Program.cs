using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _1._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string[] numbers = Console.ReadLine().Split(' ');
            var counts = new SortedDictionary<double, int>();
            foreach (var item in numbers)
            {
                double num = double.Parse(item);
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }
            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
