﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    public class TicTacToe
    {
        private int[] rows;
        private int[] cols;
        private int diagonal;
        private int antiDiagonal;
        public TicTacToe(int n)
        {
             int[] rows = new int[n];
             int[] cols = new int[n];
        }

        /** Player {player} makes a move at ({row}, {col}).
            @param row The row of the board.
            @param col The column of the board.
            @param player The player, can be either 1 or 2.
            @return The current winning condition, can be either:
                    0: No one wins.
                    1: Player 1 wins.
                    2: Player 2 wins. */
        public int move(int row, int col, int player)
        {
            int toAdd = player == 1 ? 1 : -1;
            int diagonal = 0;
            int antiDiagonal = 0;
            rows[row] += toAdd;
            cols[col] += toAdd;
            if (row == col)
            {
                diagonal += toAdd;
            }

            if (col == (cols.Length - row - 1))
            {
                antiDiagonal += toAdd;
            }

            int size = rows.Length;
            if (Math.Abs(rows[row]) == size ||
                Math.Abs(cols[col]) == size ||
                Math.Abs(diagonal) == size ||
                Math.Abs(antiDiagonal) == size)
            {
                return player;
            }

            return 0;
        }
    }
}
