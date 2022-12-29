using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_171_Title_To_Number
{
    public class Solution
    {
        public static int TitleToNumber(string columnTitle)
        {
            int ans = 0;
            foreach (char c in columnTitle)
            {
                ans = 26 * ans + ((int)c - 64);
            }
            return ans;
        }

        public static void Main(string[] args)
        {
            string columnTitle = "A";
            TitleToNumber(columnTitle);
        }
    }
}
