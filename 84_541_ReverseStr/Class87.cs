using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _84_541_ReverseStr
{
    internal class Class87
    {
        public static string ReverseStr(string s, int k)
        {
            var d = s.Length / k;
            var r = s.Length % k;

            var arr = new char[s.Length];
            for (int i = 0; i < d; i++)
            {
                if ((i & 1) == 0)
                {
                    for (int j = 0; j < k; j++)
                    {
                        arr[i * k + j] = s[(i + 1) * k - j - 1];
                    }
                }
                else
                {
                    for (int j = 0; j < k; j++)
                    {
                        arr[i * k + j] = s[i * k + j];
                    }
                }
            }

            if (r != 0)
            {
                if (d % 2 == 0)
                {
                    for (int i = 0; i < s.Length - d * k; i++)
                    {
                        arr[d * k + i] = s[s.Length - i - 1];
                    }
                }
                else
                {
                    for (int i = d * k; i < s.Length; i++)
                    {
                        arr[i] = s[i];
                    }
                }
            }
            return new string(arr);
        }

        public static void Main(string[] args)
        {
            ReverseStr("abcdefg", 5);
        }
    }
}
