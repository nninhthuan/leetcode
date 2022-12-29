using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_283_Move_Zeroes
{
    public class Solution
    {
        public static void MoveZeroes(int[] nums)
        {
            int shift = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    shift++;
                    continue;
                }

                nums[i - shift] = nums[i];
            }
            for (int i = nums.Length - shift; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

        }

        public static void Main(string[] args)
        {
            int[] candies = new int[] { 2, 3, 5, 1, 3 };
            MoveZeroes(candies);
        }
    }
}
