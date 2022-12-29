using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _83_268_Missing_Number
{
    public class Solution
    {
        public static int MissingNumber(int[] nums)
        {
            Array.Sort(nums);
            bool b = false;
            int i = 0;
            if (nums.Length > 1)
            {
                for (i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[0] == 0)
                    {
                        if (nums[i + 1] - nums[i] > 1)
                        {
                            b = true;
                            break;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }

                if (b)
                {
                    return nums[i] + 1;
                }
                else
                {
                    return nums[i] + 1;
                }
            }
            else
            {
                if (nums[0] == 1)
                {
                    return 0;
                }
                else
                {
                    return nums[0] + 1;
                }
            }
        }

        public static void Main(string[] args)
        {
            int[] grid = new int[] { 4, 2, 3 };
            MissingNumber(grid);
        }
    }
}
