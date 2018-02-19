using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var leftpart = new List<int>();
            var rightpart = new List<int>();
            int k = nums.Count / 4;
            for (int i = 0; i < k; i++)
            {
                leftpart.Add(nums[i]);
            }
            leftpart.Reverse();
            nums.Reverse();
            for (int i = 0; i < k; i++)
            {
                rightpart.Add(nums[i]);
            }
            nums.Reverse();
            List<int> topLine = leftpart.Concat(rightpart).ToList();
            int[] result = new int[topLine.Count];
            for (int i = 0; i < topLine.Count; i++)
            {
                result[i] = topLine[i] + nums[k + i];
            }
            foreach (var item in result)
            {
                Console.Write($"{item} ");

            }
        }
    }
}
