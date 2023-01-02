using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _108_7_Reverse
{
    internal class Class7
    {
        public static int Reverse(int x)
        {
            string str = new string(x.ToString().Trim('-').Reverse().ToArray());
            bool tryInt32 = int.TryParse(str, out int intValue);
            return tryInt32 ? x.ToString().Contains("-") ? intValue * -1 : intValue : 0;
        }

        public static void Main(string[] args)
        {
            Reverse(5);
        }
    }
}
