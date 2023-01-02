using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101_121_Is_Power_Of_Two
{
    internal class Class101
    {
        public static bool IsPowerOfTwo(int n)
        {
            if (n < 1)
            {
                return false;
            }
            while (n > 1)
            {
                if (n % 2 != 0)
                {
                    return false;
                }
                n = n / 2;
            }
            return true;
        }

        public static void Main(string[] args)
        {
            IsPowerOfTwo(5);
        }
    }
}
