using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _109_191_Hamming_Weight
{
    internal class Class109
    {
        public static int HammingWeight(uint n)
        {
            uint c = 0;

            while (n > 0)
            {
                c += n & 1; // or: c += n % 2;
                n >>= 1;    // or: n /= 2;
            }

            return (int)c;
        }

        public static void Main(string[] args)
        {
            HammingWeight(5);
        }
    }
}
