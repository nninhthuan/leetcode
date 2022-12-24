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
            IList<int> results = new List<int>();
            for (int i = left; i <= right; i++)
            {
                int prev = i / 10;
                int follow = i % 10;

                if (i > 0 && i < 10)
                {
                    results.Add(i);

                }

                if (prev > 0 || follow > 0)
                {
                    if(i % prev == 0 && i % follow == 0)
                    {
                        results.Add(i);
                    }
                }

                if(i > 100)
                {
                    int prev00 = i / 100;
                    int follow00 = i % 100;

                    SelfDividingNumbers(prev00, follow00);

                    if (prev00 > 0 || follow00 > 0)
                    {
                        if (i % prev00 == 0 && i % follow00 == 0)
                        {
                            results.Add(i);
                        }
                    }

                }
            }

            for(int i = 0; i < results.Count;i++)
            {
                Console.WriteLine(i);
            }
            return results;
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
