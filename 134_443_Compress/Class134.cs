using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _134_443_Compress
{
    public class Solution
    {
        public static int Compress(char[] chars)
        {
            if (chars == null) return 0;
            if (chars.Length == 1) return 1;
            int curpos = 0;
            int dup_counter = 1;
            char prechar = chars[0];
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] == chars[i - 1])
                {
                    if (i == chars.Length - 1)
                    {
                        dup_counter++;
                        set_time(chars, ref curpos, ref dup_counter, ref prechar);
                    }
                    else
                    {
                        dup_counter++;
                    }
                }
                else
                {
                    if (i == chars.Length - 1)
                    {
                        set_time(chars, ref curpos, ref dup_counter, ref prechar);
                        chars[curpos] = chars[i];
                        curpos++;
                    }
                    else
                    {
                        set_time(chars, ref curpos, ref dup_counter, ref prechar);
                        prechar = chars[i];
                    }
                }
            }
            return curpos;

        }
        public static void set_time(char[] chars, ref int curpos, ref int dup_counter, ref char prechar)
        {
            if (dup_counter == 1)
            {
                chars[curpos] = prechar;
                curpos++;
            }
            else
            {
                chars[curpos] = prechar;
                curpos++;
                string tmpstr = ""; 

                while (dup_counter > 0)
                {
                    int res = dup_counter % 10;
                    dup_counter = dup_counter / 10;
                    tmpstr = res.ToString() + tmpstr;
                } 
                foreach (char c in tmpstr)
                {
                    chars[curpos] = c;
                    curpos++;
                }
                dup_counter = 1;
            }
        }

        public static void Main(string[] args)
        {
            char[] chars = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            int result = Compress(chars);
        }
    }
}
