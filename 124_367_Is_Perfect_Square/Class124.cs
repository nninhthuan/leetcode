using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _124_367_Is_Perfect_Square
{
    public class Solution
    {
        public static bool IsPerfectSquare(int num)
        {
            int i = 0;
            while (((long)i * i) < num)
            {
                i++;
            }

            return i * i == num;
        }

        public static void Main(string[] args)
        {

            bool result = IsPerfectSquare(16);
        }
    }
}
