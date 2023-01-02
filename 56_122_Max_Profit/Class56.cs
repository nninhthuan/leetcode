using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_122_Max_Profit
{
    internal class Class56
    {
        public static int MaxProfit(int[] prices)
        {
            int totalP = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    totalP += (prices[i] - prices[i - 1]);
            }
            return totalP;
        }

        public static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, };
            MaxProfit(nums);
        }
    }
}
