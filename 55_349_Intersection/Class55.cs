using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_598_Max_Count
{
    public class Solution
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        int t = nums1[i];
                        if (dic.ContainsKey(t))
                        {
                            int tt = dic[t];
                            tt++;
                            dic[t] = tt;
                        }
                        else
                        {
                            dic.Add(t, 1);
                        }
                    }
                }
            }
            var result = new List<int>();
            foreach (var item in dic)
            {
                result.Add(item.Key);
            }
            return result.ToArray();
        }

        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4  };

            int[] arr2 = {  9, 5, 1, 2  };

            int[] result = Intersection(arr2, arr);
        }

    }
}
