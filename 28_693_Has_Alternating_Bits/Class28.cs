using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_693_Has_Alternating_Bits
{
    internal class Class28
    {
        public static bool HasAlternatingBits(int n)
        {
            int bit = n % 2;
            while (n > 0)
            {
                if (n % 2 != bit) return false;
                bit = bit is 1 ? 0 : 1;
                n /= 2;
            }

            return true;
        }

        public static void Main(string[] args)
        {
            HasAlternatingBits(5);
        }
    }
}
