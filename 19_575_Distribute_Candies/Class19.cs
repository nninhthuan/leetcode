using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_575_Distribute_Candies
{
    public class Solution
    {
        public static int DistributeCandies(int[] candyType)
        {
            int types = candyType.Distinct().Count();
            int countOfCandies = candyType.Length / 2;
            return countOfCandies <= types ? countOfCandies : types;
        }

        public static void Main(string[] args)
        {
            int[] chars = new int[] { 4, 4, 2, 2, 1, 1, 1 };
            int result = DistributeCandies(chars);
        }
    }
}
