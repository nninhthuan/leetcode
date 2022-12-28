using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64_167_Two_Sum
{
    public class Solution
    {
        public static int[] TwoSum(int[] numbers, int target)
        {

            int[] res = new int[2];

            int i = 0;
            int j = numbers.Length - 1;

            while (i < j)
            {
                int sum = numbers[i] + numbers[j];

                if (sum == target)
                {
                    res[0] = i + 1;
                    res[1] = j + 1;
                    return res;
                }

                if (sum < target)
                    i++;
                else
                    j--;
            }

            return res;
        }

        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };


            int[] result = TwoSum(arr, 5);
        }
    }
}
