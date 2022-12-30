using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _73_599_Find_Restaurant
{
    internal class Class73
    {
        public static string[] FindRestaurant(string[] list1, string[] list2)
        {
            var dict1 = new Dictionary<string, int>();
            var dict2 = new Dictionary<string, int>();
            int index = 0;

            foreach (var с in list1)
            {
                dict1.Add(с, index++);
            }

            index = 0;

            foreach (var c in list2)
            {
                if (dict1.ContainsKey(c))
                {
                    dict2.Add(c, dict1[c] + index);
                }

                index++;
            }

            var max = dict2.Min(x => x.Value);

            return dict2.Where(x => x.Value == max).Select(x => x.Key).ToArray();
        }

        public static void Main(string[] args)
        {
            string[] list1 = new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            string[] list2 = new string[] { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" };
            FindRestaurant(list1, list2);
        }
    }
}
