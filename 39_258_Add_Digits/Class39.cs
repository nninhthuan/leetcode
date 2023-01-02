using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_258_Add_Digits
{
    internal class Class39
    {
        public static int AddDigits(int num)
        {
            if (num < 10) return num;

            while (num > 9)
            {
                int newNum = 0;
                char[] nums = num.ToString().ToCharArray();
                for (int i = 0; i < nums.Length; i++) newNum += Convert.ToInt32(nums[i].ToString());
                num = newNum;
            }
            return num;
        }

        public static void Main(string[] args)
        {
            AddDigits(5);
        }
    }
}
