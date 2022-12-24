using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_728_Self_Dividing_Numbers
{
    public class Solution
    {
        public static IList<int> SelfDividingNumbers(int left, int right)
        {
            List<int> result = new List<int>();
            for (int i = left; i <= right; i++)
            {

                int prev = i;

                bool divisible = true;
                do
                {
                    if (prev % 10 == 0 || (i % (prev % 10) != 0))
                    {
                        divisible = false;
                        break;
                    }
                    prev /= 10;
                } while (prev > 0);
                if (!divisible)
                    continue;
                result.Add(i);
            }
            return result;

        }

        public static void Main(string[] args)
        {
            int left = 66;
            int right = 708;

            IList<int> numbers = new List<int>();
            numbers = SelfDividingNumbers(left, right);
        }
    }
}
