using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_832_Flip_And_Invert_Image
{
    public class Solution
    {
        public int[][] FlipAndInvertImage(int[][] image)
        {
            for (int i = 0; i < image.Length; i++)
            {
                int left = 0, right = image[i].Length - 1;
                while (left < right)
                {
                    int temp = 1 - image[i][left];
                    image[i][left] = 1 - image[i][right];
                    image[i][right] = temp;
                    left++;
                    right--;
                }
                if (left == right)
                {
                    image[i][left] = 1 - image[i][left];
                }
            }
            return image;
        }

        public static void Main(string[] args)
        {
        }
    }
}
