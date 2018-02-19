using System;
using System.Linq;

namespace _4._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').
                Select(int.Parse).ToList().OrderByDescending(x=> x).Take(3)   ;
            Console.WriteLine(string.Join(" ",num));
        }
    }
}
