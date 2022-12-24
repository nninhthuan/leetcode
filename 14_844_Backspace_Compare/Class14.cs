using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_844_Backspace_Compare
{
    public class Solution
    {
        public static bool BackspaceCompare(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            string str1 = "";
            string str2 = "";
            Stack<char> s1 = new Stack<char>();
            Stack<char> s2 = new Stack<char>();
            for (int i = 0; i < n; i++)
            {
                if (s1.Count == 0 && s[i] == '#') continue;
                if (s[i] == '#')
                    s1.Pop();
                else
                    s1.Push(s[i]);
            }
            for (int i = 0; i < m; i++)
            {
                if (s2.Count == 0 && t[i] == '#') continue;
                if (t[i] == '#')
                    s2.Pop();
                else
                    s2.Push(t[i]);
            }
            while (s1.Count > 0)
                str1 += s1.Pop();
            while (s2.Count > 0)
                str2 += s2.Pop();
            return str1 == str2;
        }

        public static void Main(string[] args)
        {
            string s = "ab#c";
            string t = "ad#c";

            bool b = BackspaceCompare(s, t);
        }
    }
}
