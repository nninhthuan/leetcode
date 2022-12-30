using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123_342_Is_Power_Of_Four
{
    internal class Class123
    {
        public static bool IsPowerOfFour(int n)
        {
            int i = 0;
            while (n != Math.Pow(4, i))
            {
                if (n < Math.Pow(4, i)) return false;
                i++;
            }
            return true;
        }

        public static void Main(string[] args)
        {
            IsPowerOfFour(5);
        }
    }
}
