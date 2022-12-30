using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_867_Transpose
{
    public class Solution
    {
        public static int[][] Transpose(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;

            int[][] results = new int[n][];
            for (int index = 0; index < n; index++)
            {
                results[index] = new int[m];
            }

            for (int row = 0; row < m; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    results[column][row] = matrix[row][column];
                }
            }

            return results;
        }

        public static void Main(string[] args)
        {
            int[][] arr = new int[][] 
            { 
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            };
            Transpose(arr);
        }
    }
}
