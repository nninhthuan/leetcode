using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58_169_Majority_Element
{
    internal class Class58
    {
        public static int MajorityElement(int[] nums)
        {
            return nums.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
        }

        public static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 3 };
            MajorityElement(nums);
        }
    }
}
