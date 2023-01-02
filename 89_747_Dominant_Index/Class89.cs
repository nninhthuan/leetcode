using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _89_747_Dominant_Index
{
    internal class Class89
    {
        public static int DominantIndex(int[] nums)
        {
            int x = nums.Max();
            int flag = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] * 2 > x && nums[i] != x)
                {
                    flag = -1; break;
                }
                if (nums[i] == x)
                {
                    flag = i;
                }
            }
            return flag;
        }

        public static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, };
            DominantIndex(nums);
        }
    }
}
