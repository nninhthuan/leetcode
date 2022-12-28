using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _94_415_Add_Strings
{
    public class Solution
    {
        public static string AddStrings(string num1, string num2)
        {
            Stack<char> stack = new();
            int carry = 0;
            int length = Math.Max(num1.Length, num2.Length);
            for (int index = 0; index < length; index++)
            {
                int left = index < num1.Length ? num1[^(index + 1)] - '0' : 0;
                int right = index < num2.Length ? num2[^(index + 1)] - '0' : 0;
                int sum = left + right + carry;
                carry = sum / 10;
                char character = (char)(sum % 10 + '0');
                stack.Push(character);
            }

            if (carry == 1) stack.Push('1');

            return new string(stack.ToArray());
        }

        public static void Main(string[] args)
        {
            string num1 = "11", num2 = "123";

            string result = AddStrings(num1, num2);
        }
    }
}
