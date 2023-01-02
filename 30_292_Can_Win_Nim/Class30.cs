using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_292_Can_Win_Nim
{
    internal class Class30
    {
        public static bool CanWinNim(int n)
        {
            return !(n % 4).Equals(0);
        }

        public static void Main(string[] args)
        {
            CanWinNim(5);
        }
    }
}
