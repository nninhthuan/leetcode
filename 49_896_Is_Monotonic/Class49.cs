using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_896_Is_Monotonic
{
    internal class Class49
    {
        public static bool IsMonotonic(int[] nums)
        {
            bool monotonicInc = false;
            bool monotonicDec = false;
            bool IncOrDec = true;
            int i = 0;
            int j = i + 1;
            while (IncOrDec && nums.Length > 2 && j < nums.Length)
            {
                if (nums[i] > nums[j])
                {
                    monotonicDec = true;
                    break;
                }
                else if (nums[i] < nums[j])
                {
                    monotonicInc = true;
                    break;
                }
                else if (nums[i] == nums[j])
                {
                    i++;
                    j++;
                }
                if (j > nums.Length)
                {
                    return false;
                }
            }

            for (i = 0; i < (nums.Length - 1); i++)
            {
                j = i + 1;
                if (monotonicInc)
                {
                    if (nums[i] > nums[j])
                        return false;
                }

                if (monotonicDec)
                {
                    if (nums[i] < nums[j])
                        return false;
                }

            }
            return true;
        }

        public static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 2, 3 };
            IsMonotonic(nums);
        }
    }
}
