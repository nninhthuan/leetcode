using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74_905_Sort_Array_By_Parity
{
    public class Solution
    {
        public static int[] SortArrayByParity(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                if (nums[left] % 2 is 0)
                {
                    left++;
                }
                else if (nums[right] % 2 is 1)
                {
                    right--;
                }
                else
                {
                    (nums[left], nums[right]) = (nums[right], nums[left]);
                }
            }

            return nums;
        }

        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };


            int[] result = SortArrayByParity(arr);
        }
    }
}
