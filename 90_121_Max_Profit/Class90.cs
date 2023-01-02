using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _90_121_Max_Profit
{
    internal class Class90
    {
        public static int MaxProfit(int[] prices)
        {
            var min = prices[0];
            var profit = 0;
            foreach (var today in prices)
            {
                profit = Math.Max(profit, today - min);
                min = Math.Min(min, today);
            }
            return profit;
        }

        public static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, };
            MaxProfit(nums);
        }
    }
}
