using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _135_434_Count_Segments
{
    internal class Class135
    {
        public static int CountSegments(string s)
        {
            int count = 0;
            if (s == null || s.Trim().Length == 0 || string.IsNullOrEmpty(s))
                return count;
            string[] words = s.Split(' ');
            foreach (string word in words)
            {
                if (word.Length > 0)
                    count++;
            }
            return count;
        }

        public static void Main(string[] args)
        {
            CountSegments("Hello, my name is John");
        }
    }
}
