using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104_917_Reverse_Only_Letters
{
    public class Solution
    {
        public static string ReverseOnlyLetters(string s)
        {
            var stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] > 64 && s[i] < 91) || (s[i] > 96 && s[i] < 123))
                {
                    stack.Push(s[i]);
                }
            }
            var chs = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] > 64 && s[i] < 91) || (s[i] > 96 && s[i] < 123))
                {
                    chs.Add(stack.Pop());
                }
                else
                {
                    chs.Add(s[i]);
                }
            }
            return new string(chs.ToArray());
        }

        public static void Main(string[] args)
        {
            string num1 = "11";

            string result = ReverseOnlyLetters(num1);
        }
    }
}
