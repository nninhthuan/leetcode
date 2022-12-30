using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77_409_Longest_Palindrome
{
    public class Solution
    {
        public static int LongestPalindrome(string s)
        {
            Dictionary<char, int> dict = new();

            foreach (var ch in s)
            {
                if (!dict.ContainsKey(ch))
                    dict.Add(ch, 0);

                dict[ch]++;
            }

            if (dict.Count == 1)
                return dict.First().Value;

            int maxLen = 0;
            bool containsOdd = false;

            foreach (var val in dict.Values)
            {
                if (val % 2 == 0)
                    maxLen += val;
                else
                {
                    maxLen += (val - 1);
                    containsOdd = true;
                }
            }

            if (containsOdd)
                return maxLen + 1;

            return maxLen;
        }

        public static void Main(string[] args)
        {
            LongestPalindrome("abccccdd");
        }
    }
}
