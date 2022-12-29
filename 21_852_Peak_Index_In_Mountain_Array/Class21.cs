using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_852_Peak_Index_In_Mountain_Array
{
    public class Solution
    {
        public static int PeakIndexInMountainArray(int[] arr)
        {
            int index = 0;
            while (index < arr.Length - 1)
            {
                if (arr[index] > arr[index + 1])
                {
                    return index;
                }
                index++;
            }
            return index;
        }

        public static void Main(string[] args)
        {
            int[] chars = new int[] { 4, 4, 2, 2, 1, 1, 1 };
            int result = PeakIndexInMountainArray(chars);
        }
    }
}
