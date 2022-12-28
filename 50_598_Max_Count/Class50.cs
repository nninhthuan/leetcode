using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_598_Max_Count
{
    public class Solution
    {
        public static int MaxCount(int m, int n, int[][] ops)
        {
            int x = m;
            int y = n;

            for (int i = 0; i < ops.Length; i++)
            {
                x = Math.Min(x, ops[i][0]);
                y = Math.Min(y, ops[i][1]);
            }

            return (x) * (y);
        }

        public static void Main(string[] args)
        {
            int[][] arr = {
                new int[]{ 1, 2, 3, 4 },
                new int[]{ 5, 1, 2, 3 },
                new int[]{ 9, 5, 1, 2 } };


            int result = MaxCount(5,6,arr);
        }
    }
}
