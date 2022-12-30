using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _133_172_Trailing_Zeroes
{
    internal class Class133
    {
        public static int TrailingZeroes(int n)
        {
            int ans = 0;
            while (n > 0)
            {
                ans += n / 5;
                n /= 5;
            }

            return ans;
        }  

        public static void Main(string[] args)
        {
            TrailingZeroes(5);
        }
    }
}
