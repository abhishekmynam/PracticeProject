using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class FindingIslandDFS
    {
        public int numIslands(char[,] grid)
        {
            int count = 0;

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(0); j++)
                {
                    if (grid[i,j] == '1')
                    {
                        count++;
                        clearRestOfLand(grid, i, j);
                    }
                }
            }
            return count;
        }

        private void clearRestOfLand(char[,] grid, int i, int j)
        {
            if (i < 0 || j < 0 || i >= grid.GetLength(0) || j >= grid.GetLength(0) || grid[i,j] == '0') return;

            grid[i,j] = '0';
            clearRestOfLand(grid, i + 1, j);
            clearRestOfLand(grid, i - 1, j);
            clearRestOfLand(grid, i, j + 1);
            clearRestOfLand(grid, i, j - 1);
            return;
        }
    }
}
