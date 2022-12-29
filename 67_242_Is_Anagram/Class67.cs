using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67_242_Is_Anagram
{
    public class Solution
    {
        public static bool IsAnagram(string s, string t)
        {

            return s.OrderBy(c => c).SequenceEqual(t.OrderBy(x => x));

        }

        public static void Main(string[] args)
        {
            IsAnagram("anagram", "nagaram");
        }
    }
}
