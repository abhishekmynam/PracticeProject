using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class WordSearch
    {
        static bool[,] visited;
        public bool exist(char[,] board, String word)
        {
            visited = new bool[board.GetLength(0), board.GetLength(1)];

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(i); j++)
                {
                    if ((word[0] == board[i, j]) && search(board, word, i, j, 0))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool search(char[,] board, String word, int i, int j, int index)
        {
            if (index == word.Length)
            {
                return true;
            }

            if (i >= board.Length || i < 0 || j >= board.GetLength(i) || j < 0 || board[i,j] != word[index] || visited[i,j])
            {
                return false;
            }

            visited[i,j] = true;
            if (search(board, word, i - 1, j, index + 1) ||
               search(board, word, i + 1, j, index + 1) ||
               search(board, word, i, j - 1, index + 1) ||
               search(board, word, i, j + 1, index + 1))
            {
                return true;
            }

            visited[i,j] = false;
            return false;
        }
    }
}
