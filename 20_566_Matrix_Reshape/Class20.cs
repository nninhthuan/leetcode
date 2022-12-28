using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_566_Matrix_Reshape
{
    public class Solution
    {
        public static int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            List<int> lst = new();
            int[][] res = new int[r][];
            for (int i = 0; i < mat.Length; i++)
                for (int j = 0; j < mat[0].Length; j++)
                    lst.Add(mat[i][j]);
            if (r * c != lst.Count) return mat;
            int rows = 0;
            int counter = 0;
            while (rows < r)
            {
                res[rows] = new int[c];
                for (int i = 0; i < c; i++)
                    res[rows][i] = lst[counter++];
                rows++;
            }
            return res;
        }

        public static void Main(string[] args)
        {
            int[][] arr = {
                new int[]{ 1, 2, 3, 4 },
                new int[]{ 5, 1, 2, 3 },
                new int[]{ 9, 5, 1, 2 } };


            int[][] result = MatrixReshape(arr,5,6);
        }
    }
}
