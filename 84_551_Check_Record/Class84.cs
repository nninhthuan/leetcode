using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _84_551_Check_Record
{
    public class Solution
    {
        public static bool CheckRecord(string s)
        {
            int absences = 0;
            int consecutiveLates = 0;

            foreach (char character in s)
            {
                if (character is 'L')
                {
                    consecutiveLates++;
                    if (consecutiveLates == 3) return false;
                }
                else
                {
                    consecutiveLates = 0;
                }

                if (character is 'A') absences++;
            }

            return absences < 2;
        }

        public static void Main(string[] args)
        {
            string s = "PPALLP";


            bool result = CheckRecord(s);
        }
    }
}
