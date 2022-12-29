using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_521_Find_LUS_length
{
    public class Solution
    {
        public static int FindLUSlength(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return a.Length;
            }
            else if (b.Length > a.Length)
            {
                return b.Length;
            }
            //handle a.Length == b.Length
            if (a.IndexOf(b) < 0)
            {
                return b.Length;
            }
            return -1;
        }

        public static void Main(string[] args)
        {
            FindLUSlength("IDID", "IID");
        }
    }
}
