using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_476_Find_Complement
{
    public class Solution
    {
        public static int FindComplement(int num)
        {
            int mask = 1;
            int result = 0;
            while (num != 0)
            {
                if ((num & 1) == 0) result |= mask;
                mask <<= 1;
                num >>= 1;
            }

            return result;
        }

        public static void Main(string[] args)
        {
            int num = 5; //101 = 010

            int numbers = FindComplement(num);
        }
    }
}
