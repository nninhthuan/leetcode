using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_561_Array_Pair_Sum
{
    public class Solution
    {
        public static int ArrayPairSum(int[] nums)
        {
            int sum = 0;
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 1; i += 2)
            {
                sum += nums[i];
            }

            return sum;
        }

        public static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 4, 3, 2 };
            int result = ArrayPairSum(nums);
        }
    }
}
