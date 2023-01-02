using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _86_746_Min_Cost_Climbing_Stairs
{
    internal class Class86
    {
        public static int MinCostClimbingStairs(int[] cost)
        {
            int a = cost[cost.Length - 1];
            int b = cost[cost.Length - 2];
            int c = 0;

            for (int i = cost.Length - 3; i >= 0; i--)
            {
                c = cost[i] + Math.Min(b, a);
                a = b;
                b = c;
            }

            return Math.Min(b, a);
        }

        public static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, };
            MinCostClimbingStairs(nums);
        }
    }
}
