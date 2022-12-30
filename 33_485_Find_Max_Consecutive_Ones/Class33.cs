using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_485_Find_Max_Consecutive_Ones
{
    public class Solution
    {
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int n = nums.Length;
            int count = 0;
            int max = Int32.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == 0)
                {
                    if (count > max)
                        max = count;
                    count = 0;
                }
                else
                    count++;
            }
            if (count > max)
                max = count;
            return max;
        }

        public static void Main(string[] args)
        {
            int[] arr = new int[] {1, 2, 3  };
            FindMaxConsecutiveOnes(arr);
        }
    }
}
