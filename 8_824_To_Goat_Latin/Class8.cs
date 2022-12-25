using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_824_To_Goat_Latin
{
    public class Solution
    {
        public static string ToGoatLatin(string sentence)
        {
            StringBuilder sb = new StringBuilder();
            string[] arr = sentence.Split(' ');
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int count = 1;

            foreach (string s in arr)
            {
                StringBuilder nsb = new StringBuilder();

                if (vowels.Contains(char.ToLower(s[0])))
                    nsb.Append(s);
                else
                    nsb.Append(s.Substring(1)).Append(s[0]);

                nsb.Append("ma").Append(new string('a', count));
                sb.Append(nsb).Append(' ');

                count++;
            }

            return sb.ToString().TrimEnd();
        }

        public static void Main(string[] args)
        {
            //int[] chars = new int[] { 4, 4, 2, 2, 1, 1, 1 };
            string result = ToGoatLatin("I speak Goat Latin");
        }
    }
}
