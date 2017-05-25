using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class BattleShipsOnBoard
    {
        public int CountBattleships(char[,] board)
        {
            if (board == null || board.GetLength(0) == 0 || board.GetLength(1) == 0) return 0;
            int R = board.GetLength(0), C = board.GetLength(1), cnt = 0;
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (board[i,j] == 'X' && (i == 0 || board[i - 1,j] == '.') && (j == 0 || board[i,j - 1] == '.'))
                        cnt++;
                }
            }
            return cnt;
        }
    }
}
