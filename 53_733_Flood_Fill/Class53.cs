using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_733_Flood_Fill
{
    public class Solution
    {
        public static int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            var i = image.GetLength(0);
            var j = image[0].Length;
            int prevColor = image[sr][sc];
            if (prevColor == color)
            {
                return image;
            }
            image[sr][sc] = color;

            var left = sc - 1;
            if (left >= 0 && image[sr][left] == prevColor)
            {
                FloodFill(image, sr, left, color);
            }
            var right = sc + 1;
            if (right < j && image[sr][right] == prevColor)
            {
                FloodFill(image, sr, right, color);
            }
            var up = sr - 1;
            if (up >= 0 && image[up][sc] == prevColor)
            {
                FloodFill(image, up, sc, color);
            }
            var down = sr + 1;
            if (down < i && image[down][sc] == prevColor)
            {
                FloodFill(image, down, sc, color);
            }
            return image;
        }

        public static void Main(string[] args)
        {
            int[][] arr = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            };
            FloodFill(arr,  0,  0,  0);
        }
    }
}
