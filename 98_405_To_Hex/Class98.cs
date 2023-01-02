using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _98_405_To_Hex
{
    internal class Class98
    {
        public static string ToHex(int num)
        {
            if (num == 0) return "0";

            var letters = new char[]
                  {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
             'a', 'b', 'c', 'd', 'e', 'f'};

            var remainder = (uint)num;
            var digits = new List<char>();
            while (remainder > 0)
            {
                var digit = remainder % 16;
                remainder /= 16;
                digits.Add(letters[digit]);
            }

            digits.Reverse();
            return new string(digits.ToArray());
        }

        public static void Main(string[] args)
        {
            ToHex(5);
        }
    }
}
