using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78_744_Next_Greatest_Letter
{
    public class Solution
    {
        public static char NextGreatestLetter(char[] letters, char target)
        {
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] > target) return letters[i];
            }

            return letters[0];
        }

        public static void Main(string[] args)
        {
            char[] letters = new char[] { 'c', 'f', 'j' };
            NextGreatestLetter(letters, 'a');
        }
    }
}
