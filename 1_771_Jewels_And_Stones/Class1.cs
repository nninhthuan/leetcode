using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_771_Jewels_And_Stones
{
    public class Class1
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            jewels.ToCharArray();
            stones.ToCharArray();
            int jewelsLength = jewels.Length, stonesLength = stones.Length, count = 0;

            for (int i = 0; i < jewelsLength; i++)
            {
                for (int j = 0; j < stonesLength; j++)
                {
                    if (jewels[i] == stones[j])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
            return count;
        }
    }
}
