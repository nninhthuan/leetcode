using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113_35_Search_Insert
{
    internal class Class113
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int i = 0;
            int j = nums.Length - 1;
            while (i <= j)
            {
                int mid = i + (j - i) / 2;
                if (target < nums[mid])
                    j = mid - 1;
                else if (target > nums[mid])
                    i = mid + 1;
                else
                    return mid;
            }
            return i;
        }

        public static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3 };
            SearchInsert(ints, 5);
        }
    }
}
