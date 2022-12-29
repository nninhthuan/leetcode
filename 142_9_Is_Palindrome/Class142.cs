using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _142_9_Is_Palindrome
{
    public class Solution
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            var digits = 1;

            for (var i = x; i / 10 != 0; i /= 10) digits++;

            int Pow(int a, int b) => (int)Math.Pow(a, b);

            for (int i = 0, j = digits - i - 1; i < digits; i++, j--)
            {
                var first = x % Pow(10, i + 1) / Pow(10, i);
                var second = x % Pow(10, j + 1) / Pow(10, j);

                if (first != second) { return false; }
            }

            return true;
        }

        public static void Main(string[] args)
        {
            IsPalindrome(6);
        }
    }
}
