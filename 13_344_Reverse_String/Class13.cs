using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_344_Reverse_String
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                char tmp = s[i];
                s[i] = s[j];
                s[j] = tmp;
                i++;
                j--;
            }
        }
    }
}
