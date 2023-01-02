using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _85_504_Convert_To_Base7
{
    internal class Class85
    {
        public static string ConvertToBase7(int num)
        {
            var nums = "";
            var abs = "";

            switch (num)
            {
                case 0:
                    return num.ToString();
                case < 0:
                    num = Math.Abs(num);
                    abs += "-";
                    break;
            }

            while (num != 0)
            {
                var rem = num % 7;
                num = num / 7;
                nums += rem;
            }
            nums = new string(nums.Reverse().ToArray());
            return abs + nums;
        }

        public static void Main(string[] args)
        {
            ConvertToBase7(5);
        }
    }
}
