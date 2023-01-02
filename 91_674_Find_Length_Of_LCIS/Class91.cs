using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _91_674_Find_Length_Of_LCIS
{
    internal class Class91
    {
        public static int FindLengthOfLCIS(int[] nums)
        {
            int n = nums.Length;
            int max = Int32.MinValue;
            int count = 1;
            for (int i = 0; i < n - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                    count++;
                else
                {
                    if (count > max)
                        max = count;
                    count = 1;
                }
            }
            if (count > max)
                max = count;
            return max;
        }

        public static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, };
            FindLengthOfLCIS(nums);
        }
    }
}
