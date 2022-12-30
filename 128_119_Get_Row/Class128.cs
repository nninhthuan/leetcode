using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _128_119_Get_Row
{
    internal class Class128
    {
        public static IList<int> GetRow(int rowIndex)
        {
            int[,] pascal = new int[rowIndex + 1, rowIndex + 1];

            for (int i = 0; i <= rowIndex; i++)
            {
                pascal[i, 0] = 1;
                pascal[i, i] = 1;
                for (int j = 1; j < i; j++)
                {
                    pascal[i, j] = pascal[i - 1, j - 1] + pascal[i - 1, j];
                }

            }
            List<int> output = new List<int>();
            for (var i = 0; i <= rowIndex; i++)
                output.Add(pascal[rowIndex, i]);

            return output;
        }

        public static void Main(string[] args)
        {
            GetRow(5);
        }
    }
}
