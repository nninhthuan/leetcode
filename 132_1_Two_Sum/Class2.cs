using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _132_1_Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int numsCount = nums.Length - 1;
            int[] newAr = new int[2];

            for (int i = 0; i < numsCount; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        newAr[0] = i;
                        newAr[1] = j;
                    }
                }
            }
            return newAr;
        }
    }
}
