using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_317_Is_One_Bit_Character
{
    public class Solution
    {
        public static bool IsOneBitCharacter(int[] bits)
        {
            bool isTwoBitsCharacter = false;
            foreach (int bit in bits[..^1])
            {
                if (isTwoBitsCharacter)
                {
                    isTwoBitsCharacter = false;
                }
                else
                {
                    isTwoBitsCharacter = bit == 1;
                }
            }

            return isTwoBitsCharacter is false;
        }

        public static void Main(string[] args)
        {
            int[] grid = new int[] {  4, 2, 3      };
            IsOneBitCharacter(grid);
        }
    }
}
