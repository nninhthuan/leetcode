using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_453_Min_Moves
{
    public class Solution
    {
        public static int MinMoves(int[] nums)
        {
            int moves = 0;
            int min = nums.Min();
            for (int i = 0; i < nums.Length; i++)
            {
                moves += nums[i] - min;
            }
            return moves;
        }
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 }  ;


            int result = MinMoves( arr);
        }

    }
}
