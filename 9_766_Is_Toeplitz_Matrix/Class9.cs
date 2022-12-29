using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_766_Is_Toeplitz_Matrix
{
    public class Solution
    {
        public static bool IsToeplitzMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int column = 0; column < matrix[0].Length - 1; column++)
                {
                    if (matrix[row][column] != matrix[row + 1][column + 1]) return false;
                }
            }

            return true;
        }

        public static void Main(string[] args)
        {
            int[][] arr = { 
                new int[]{ 1, 2, 3, 4 },
                new int[]{ 5, 1, 2, 3 },
                new int[]{ 9, 5, 1, 2 } };


            bool result = IsToeplitzMatrix(arr);
        }
    }
}
