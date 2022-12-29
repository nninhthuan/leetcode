using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59_13_RomanToInt
{
    public class Solution
    {
        public static int RomanToInt(string s)
        {
            if (s == string.Empty)
                return 0;

            int i = 0;
            int result = 0;
            var romans = new Dictionary<char, int>()
            {
                ['I'] = 1,
                ['V'] = 5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000
            };

            while (i < s.Length - 1)
            {
                result += (romans[s[i + 1]] > romans[s[i]])
                            ? -romans[s[i]] : romans[s[i]];
                i++;
            }
            result += romans[s[s.Length - 1]];

            return result;
        }

        public static void Main(string[] args)
        {
            string s = "III";
            int result = RomanToInt(s);
        }
    }
}
