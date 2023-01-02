using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _148_999_Num_Rook_Captures
{
    internal class Class148
    {
        public static int NumRookCaptures(char[][] board)
        {
            (int row, int column) = GetPositionOfRock();
            return HowManyPawnsCanAttack(row + 0, column + 1, +0, +1)
                   + HowManyPawnsCanAttack(row + 0, column - 1, +0, -1)
                   + HowManyPawnsCanAttack(row + 1, column + 0, +1, +0)
                   + HowManyPawnsCanAttack(row - 1, column + 0, -1, +0);


            (int Row, int Column) GetPositionOfRock()
            {
                for (int row = 0; row < 8; row++)
                {
                    for (int column = 0; column < 8; column++)
                    {
                        if (board[row][column] is 'R') return (row, column);
                    }
                }

                return (0, 0);
            }

            int HowManyPawnsCanAttack(int row, int column, int offsetRow, int offsetColumn)
            {
                while (row is not -1 and not 8 && column is not -1 and not 8 && board[row][column] is '.' or 'p')
                {
                    if (board[row][column] is 'p') return 1;
                    (row, column) = (row + offsetRow, column + offsetColumn);
                }

                return 0;
            }
        }

        public static void Main(string[] args)
        {
            char[][] board = new char[][] 
            {
                new char[]{ '.', '.', '.', '.', '.', '.', '.', '.' }
            };
            NumRookCaptures(board);
        }
    }
}
