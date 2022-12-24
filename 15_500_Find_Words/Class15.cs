using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _15_500_Find_Words
{
    public class Solution
    {
        public static string[] FindWords(string[] words)
        {
            var kb = new string[] { "qwertyuiop", "asdfghjkl", "zxcvbnm" };

            var keyboard = new Dictionary<char, int>();
            for (var i = 0; i < kb.Length; i++)
            {
                for (var j = 0; j < kb[i].Length; j++)
                {
                    keyboard.Add(kb[i][j], i);
                }
            }

            var result = new List<string>();

            for (var i = 0; i < words.Length; i++)
            {
                var row = -1;

                for (var j = 0; j < words[i].Length; j++)
                {
                    var ch = char.ToLower(words[i][j]);

                    if (row != -1 && row != keyboard[ch])
                    {
                        row = -1;
                        break;
                    }

                    row = keyboard[ch];
                }

                if (row != -1)
                {
                    result.Add(words[i]);
                }
            }

            return result.ToArray();
        }

        public static void Main(string[] args)
        {
            string[] words = new string[] { "Hello", "Alaska", "Dad", "Peace"};
            string[] result = FindWords(words);
        }
    }
}
