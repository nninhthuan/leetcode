using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_884_Uncommon_From_Sentences
{
    public class Solution
    {
        public static string[] UncommonFromSentences(string s1, string s2)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string[] words1 = s1.Split(' ');
            string[] words2 = s2.Split(' ');
            var wordsBoth = words1.Concat(words2);

            // count the word occurances.
            foreach (string word in wordsBoth)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict[word] = 1;
                }
            }

            List<string> ansList = new List<string>();
            foreach (KeyValuePair<string, int> dictWord in dict)
            {
                if (dictWord.Value == 1)
                {
                    ansList.Add(dictWord.Key);
                }
            }

            return ansList.ToArray();
        }

        public static void Main(string[] args)
        {
            string s1 = "this apple is sweet", s2 = "this apple is sour";

            string[] result = UncommonFromSentences(s1, s2);
        }
    }
}
