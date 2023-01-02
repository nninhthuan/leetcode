using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _97_594_FindLHS
{
    internal class Class97
    {
        public static int FindLHS(int[] nums)
        {
            if (nums.Distinct().Count() == 1)
            {
                return 0;
            }
            Array.Sort(nums);
            var list = new List<int>();
            var group = nums.GroupBy(n => n).Select(g => new { key = g.Key, count = g.Count() }).ToArray();
            for (int i = 0; i < group.Length - 1; i++)
            {
                if (group[i].key == group[i + 1].key - 1)
                {
                    list.Add(group[i].count + group[i + 1].count);
                }
                else
                {
                    if (i == group.Length - 2)
                    {
                        list.Add(group[i + 1].count);
                    }
                }
            }
            if (list.Count == 0 || list.Max() == 1)
            {
                return 0;
            }
            return list.Max();
        }

        public static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, };
            FindLHS(nums);
        }
    }
}
