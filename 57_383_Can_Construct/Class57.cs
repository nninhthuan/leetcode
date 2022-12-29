using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_383_Can_Construct
{
    public class Solution
    {
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            char[] ransomArr = ransomNote.ToArray();
            char[] magArr = magazine.ToArray();
            Array.Sort(ransomArr);
            Array.Sort(magArr);
            int cmpItr = 0;
            foreach (var a in magArr)
            {
                if (a == ransomArr[cmpItr])
                {
                    cmpItr++;
                    if (cmpItr == ransomNote.Length)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static void Main(string[] args)
        {
            bool result = CanConstruct("aa", "ab");
        }
    }
}
