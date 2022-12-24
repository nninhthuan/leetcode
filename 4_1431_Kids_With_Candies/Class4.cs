using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1431_Kids_With_Candies
{
    public class Solution
    {
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            List<bool> result = new List<bool>();
            int maxValue = candies.Max();

            for (int i = 0; i < candies.Length; i++)
                if (candies[i] + extraCandies >= maxValue)
                    result.Add(true);
                else
                    result.Add(false);

            return result;
        }

        public static void Main(string[] args)
        {
            int[] candies = new int[] { 2, 3, 5, 1, 3 };
            int extraCandies = 3;
            IList<bool> result = KidsWithCandies(candies, extraCandies);
        }
    }
}
