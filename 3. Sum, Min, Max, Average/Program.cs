using System;
using System.Linq;

namespace _3._Sum__Min__Max__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDigit = int.Parse(Console.ReadLine());
            int[] num = new int[numOfDigit];
            for (int i = 0; i < numOfDigit; i++)
            {
             int current = int.Parse(Console.ReadLine());
                num[i] = current;
            }
           Console.WriteLine($"Sum = {num.Sum()}");
           Console.WriteLine($"Min = {num.Min()}");
           Console.WriteLine($"Max = {num.Max()}");
           Console.WriteLine($"Average = {num.Average()}");
        }
    }
}
