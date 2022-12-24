using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_412_Fizz_Buzz
{
    public class Solution
    {
        public static IList<string> FizzBuzz(int n)
        {
            List<string> result = new List<string>();

            for (int i = 1; i != n + 1; i++)
            {
                string fiz = "";
                if (i % 3 == 0) fiz = "Fizz";

                if (i % 5 == 0) fiz += "Buzz";

                if (fiz == "") fiz = "" + i;

                result.Add(fiz);
            }

            return result;
        }

        public static void Main(string[] args)
        {
            int n = 5;
            IList<string> result = FizzBuzz(n);
        }
    }

    
}


