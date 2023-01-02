using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_520_Detect_Capital_Use
{
    internal class Class380
    {
        public static bool DetectCapitalUse(string word)
        {
            return word.All(char.IsUpper) || word.Skip(1).All(char.IsLower);
        }

        public static void Main(string[] args)
        {
            DetectCapitalUse("USA");
        }
    }
}
