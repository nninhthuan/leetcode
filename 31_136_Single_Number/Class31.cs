using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_136_Single_Number
{
    public class Solution
    {
        public static int SingleNumber(int[] nums)
        {
            int first = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                first ^= nums[i];
            }
        
            return first;
        }

        public static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 2, 1 };
            int result = SingleNumber(nums); 
        }
    }
}
