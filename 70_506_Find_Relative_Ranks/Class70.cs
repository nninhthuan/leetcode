using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_506_Find_Relative_Ranks
{
    internal class Class70
    {
        public static string[] FindRelativeRanks(int[] score)
        {
            var dic = new Dictionary<int, string>();
            var copy = new int[score.Length];
            copy = score[0..];
            Array.Sort(copy);
            Array.Reverse(copy);
            for (int i = 0; i < copy.Length; i++)
            {
                dic.Add(copy[i], $"{i + 1}");
            }
            var list = new List<string>();
            for (int i = 0; i < score.Length; i++)
            {
                var rank = dic[score[i]] switch
                {
                    "1" => "Gold Medal",
                    "2" => "Silver Medal",
                    "3" => "Bronze Medal",
                    _ => dic[score[i]]
                };
                list.Add(rank);
            }
            return list.ToArray();
        }

        public static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, };
            FindRelativeRanks(nums);
        }
    }
}
