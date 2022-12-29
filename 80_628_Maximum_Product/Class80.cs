using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80_628_Maximum_Product
{
    public class Solution
    {
        public static int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);

            int len = nums.Length;
            int startMul = nums[0] * nums[1];
            int endMul = nums[len - 2] * nums[len - 3];

            if (nums[len - 1] > 0)
            {
                return nums[len - 1] * (startMul > endMul ? startMul : endMul);
            }
            else
            {
                return nums[len - 1] * endMul;
            }
        }

        public static void Main(string[] args)
        {
            int[] grid = new int[] { 4, 2, 3 };
            MaximumProduct(grid);
        }
    }
}
