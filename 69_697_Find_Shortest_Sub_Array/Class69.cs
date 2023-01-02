using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69_697_Find_Shortest_Sub_Array
{
    internal class Class69
    {
        public static int FindShortestSubArray(int[] nums)
        {
            var degrees = nums.GroupBy(p => p).Select(g => new { key = g.Key, count = g.Count() }).OrderByDescending(g => g.count).ToList();
            var maxdegree = degrees.First().count;
            var filtered = degrees.Where(d => d.count == maxdegree).ToList();

            var minlen = nums.Length + 1;
            foreach (var f in filtered)
            {
                var diff = nums.ToList().LastIndexOf(f.key) - nums.ToList().IndexOf(f.key) + 1;
                if (minlen > diff)
                {
                    minlen = diff;
                }
            }
            return minlen;
        }

        public static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, };
            FindShortestSubArray(nums);
        }
    }
}
