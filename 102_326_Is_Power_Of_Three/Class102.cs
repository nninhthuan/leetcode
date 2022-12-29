using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102_326_Is_Power_Of_Three
{
    public class Solution
    {
        public static bool IsPowerOfThree(int n)
        {
            if (n < 1) { return false; }
            for (int x = 0; x < 631; x++)
            {
                int res = (int)Math.Pow(3, x);
                if (res == n)
                {
                    return true;
                }
                if (res > n)
                {
                    return false;
                }
            }
            return false;
        }

        public static void Main(string[] args)
        {
            IsPowerOfThree(5);
        }
    }
}
