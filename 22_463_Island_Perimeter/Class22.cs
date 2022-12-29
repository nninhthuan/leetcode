using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_463_Island_Perimeter
{
    public class Solution
    {
        public static int IslandPerimeter(int[][] grid)
        {
            Queue<(int r, int c)> q = new Queue<(int, int)>();
            int row = grid.Length;
            int col = grid[0].Length;
            bool[,] visited = new bool[row, col];
            int perimeter = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (grid[i][j] == 1 && !visited[i, j])
                    {
                        q.Enqueue((i, j));
                        while (q.Count > 0)
                        {
                            //first step remove the element from the queue
                            int r1 = q.Peek().r;
                            int c1 = q.Peek().c;
                            q.Dequeue();
                            if (visited[r1, c1]) continue;
                            if (r1 == 0) perimeter++;
                            if (c1 == 0) perimeter++;
                            if (r1 == row - 1) perimeter++;
                            if (c1 == col - 1) perimeter++;
                            visited[r1, c1] = true;

                            //second step is to check if the adjacents are water or boundary
                            if (r1 - 1 >= 0)
                            {
                                if (grid[r1 - 1][c1] == 0)
                                    perimeter++;
                                else
                                    q.Enqueue((r1 - 1, c1));
                            }
                            if (r1 + 1 <= row - 1)
                            {
                                if (grid[r1 + 1][c1] == 0)
                                    perimeter++;
                                else
                                    q.Enqueue((r1 + 1, c1));
                            }
                            if (c1 - 1 >= 0)
                            {
                                if (grid[r1][c1 - 1] == 0)
                                    perimeter++;
                                else
                                    q.Enqueue((r1, c1 - 1));
                            }
                            if (c1 + 1 <= col - 1)
                            {
                                if (grid[r1][c1 + 1] == 0)
                                    perimeter++;
                                else
                                    q.Enqueue((r1, c1 + 1));
                            }
                        }
                    }
                }
            }
            return perimeter;
        }

        public static void Main(string[] args)
        {
            int[][] grid = {new int[] {0,1,0,0 },
                new int[] {1,1,1,0 },
                new int[] {0,1,0,0 },
                new int[] {1,1,0,0 } };

            int result = IslandPerimeter(grid);
        }

    }
}
