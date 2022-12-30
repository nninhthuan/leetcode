using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63_387_First_Uniq_Char
{
    public class Solution
    {
        public static int FirstUniqChar(string s)
        {
            HashSet<char> CharsBlackList = new HashSet<char>();
            HashSet<char> UniqChars = new HashSet<char>();
            foreach (char c in s)
            {
                if (UniqChars.Contains(c))
                {
                    CharsBlackList.Add(c);
                    UniqChars.Remove(c);
                }
                else if (!CharsBlackList.Contains(c))
                {
                    UniqChars.Add(c);
                }

            }

            for (int i = 0; i < s.Length; i++)
            {
                if (UniqChars.Contains(s[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public static void Main(string[] args)
        {
            FirstUniqChar("loveleetcode");
        }
    }
}
