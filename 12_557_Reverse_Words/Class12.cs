using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_557_Reverse_Words
{
    public class Solution
    {
        public static string ReverseWords(string s)
        {
            var strings = s.Split(' ');
            var sb = new StringBuilder();
            foreach (string str in strings)
            {
                for (var i = str.Length - 1; i >= 0; i--)
                {
                    sb.Append(str[i]);
                }
                sb.Append(' ');
            }
            return sb.ToString().TrimEnd();
        }

        public static void Main(string[] args)
        {
            string s = "Let's take LeetCode contest";
            string result = ReverseWords(s);
        }
    }
}
