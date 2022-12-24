using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_682_Cal_Points
{
    public class Solution
    {
        public static int CalPoints(string[] operations)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < operations.Length; i++)
            {
                switch (operations[i])
                {
                    case "C":
                        list.RemoveAt(list.Count - 1);
                        break;
                    case "D":
                        list.Add(list[list.Count - 1] * 2);
                        break;
                    case "+":
                        list.Add(list[list.Count - 1] + list[list.Count - 2]);
                        break;
                    default:
                        list.Add(int.Parse(operations[i]));
                        break;
                }
            }

            return list.Sum(x => Convert.ToInt32(x));
        }

        public static void Main(string[] args)
        {
            string[] ops = new string[] {"5", "2", "C", "D", "+" };
            int result = CalPoints(ops);
        }
    }
}
