using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_461_Hamming_Distance
{
    public class Solution
    {
        public static int HammingDistance(int x, int y)
        {
            int diff = x ^ y;
            int result = 0;
            while (diff > 0)
            {
                result += diff & 1;
                diff /= 2;
            }
            Console.WriteLine(result);
            return result;
        }

        public static void Main(string[] args)
        {
            int x = 1, y = 4;

            int result = HammingDistance(x, y);
        }

    }
}
