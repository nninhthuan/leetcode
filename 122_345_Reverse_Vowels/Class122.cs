using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _122_345_Reverse_Vowels
{
    public class Solution
    {
        public static string ReverseVowels(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>(){
            {'a',97},{'e',101},{'i',105},{'o',111},{'u',117},{'A',65},{'E',69},{'I',73},{'O',79},{'U',85}};
            StringBuilder sb = new StringBuilder(s);
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                if (!dic.ContainsKey(sb[left])) left++;
                else if (!dic.ContainsKey(sb[right])) right--;
                else
                {
                    sb[left] = s[right];
                    sb[right] = s[left];
                    left++;
                    right--;
                }
            }
            return sb.ToString();
        }

        public static void Main(string[] args)
        {
            ReverseVowels("hello");
        }
    }
}
