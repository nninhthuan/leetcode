using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_418_Find_Disappeared_Numbers
{
    internal class Class41
    {
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] > 0) nums[index] = -nums[index];
            }
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0) result.Add(i + 1);
            }
            return result;
        }

        public static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, };
            FindDisappearedNumbers(nums);
        }
    }
}
