using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _93_720_Longest_Word
{
    internal class Class93
    {
        public static string LongestWord(string[] words)
        {
            var trie = new List<(int, string)[]>();
            trie.Add(new (int, string)[26]);
            foreach (var word in words)
            {
                int cur = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    var c = word[i];
                    if (trie[cur][c - 'a'].Item1 == 0)
                    {
                        trie.Add(new (int, string)[26]);
                        trie[cur][c - 'a'].Item1 = trie.Count - 1;
                    }
                    if (i == word.Length - 1)
                        trie[cur][c - 'a'].Item2 = word;
                    cur = trie[cur][c - 'a'].Item1;
                }
            }
            return DFS(trie, 0);
        }

        private static string DFS(List<(int, string)[]> trie, int cur)
        {
            string result = string.Empty;
            foreach (var pair in trie[cur])
            {
                if (pair.Item2 == null)
                    continue;
                if (result.Length < pair.Item2.Length)
                    result = pair.Item2;
                var res = DFS(trie, pair.Item1);
                if (result.Length < res.Length)
                    result = res;
            }
            return result;
        }

        public static void Main(string[] args)
        {
            string[] list1 = new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            LongestWord(list1);
        }
    }
}
