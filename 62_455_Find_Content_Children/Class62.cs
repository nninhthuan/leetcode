using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62_455_Find_Content_Children
{
    public class Solution
    {
        public static int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            var index = 0;
            foreach (var sc in s)
            {
                if (sc >= g[index])
                {
                    index++;
                }
                if (index >= g.Length)
                {
                    break;
                }
            }
            return index;
        }

        public static void Main(string[] args)
        {
            int[] g = new int[] { 1, 2, 3 };
            int[] s = new int[] { 1, 1 };
            FindContentChildren(g, s);
        }

    }
}
