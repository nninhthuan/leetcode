using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_389_Find_The_Difference
{
    public class Solution
    {
        public static char FindTheDifference(string s, string t)
        {
            int n = s.Length;
            char[] arr1 = s.ToCharArray();
            char[] arr2 = t.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            for (int i = 0; i < n; i++)
                if (arr1[i] != arr2[i])
                    return arr2[i];
            return arr2[n];
        }

        public static void Main(string[] args)
        {
            string s = "abcd", t = "abcde";
            char result = FindTheDifference(s ,t);
        }
    }
}
