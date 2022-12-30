using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _96_202_Is_Happy
{
    public class Solution
    {
        public static bool IsHappy(int n)
        {
            var hashset = new HashSet<int>();

            while (n != 1)
            {
                var currentNumber = n;
                n = 0;

                while (currentNumber > 0)
                {
                    n += (int)Math.Pow(currentNumber % 10, 2);
                    currentNumber /= 10;
                }

                if (hashset.Contains(n))
                {
                    return false;
                }

                hashset.Add(n);
            }

            return true;
        }

        public static void Main(string[] args)
        {
            IsHappy(19);
        }
    }
}
