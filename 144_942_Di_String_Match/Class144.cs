using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _144_942_Di_String_Match
{
    public class Solution
    {
        public static int[] DiStringMatch(string S)
        {
            int[] result = new int[S.Length + 1];
            int d = 0;
            int i = S.Length;
            int index = 0;
            foreach (char c in S)
            {
                if (c == 'D') result[index++] = i--;
                if (c == 'I') result[index++] = d++;
            }
            result[index] = i;
            return result;
        }

        public static void Main(string[] args)
        {
            DiStringMatch("IDID");
        }
    }
}
