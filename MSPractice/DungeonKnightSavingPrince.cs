using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class DungeonKnightSavingPrince
    {
        public int calculateMinimumHP(int[,] dungeon) 
        {
            if (dungeon == null || dungeon.GetLength(0) == 0 || dungeon.GetLength(1) == 0) return 0;
    
            int m = dungeon.GetLength(0);
            int n = dungeon.GetLength(1);
    
            int[,] health = new int[m,n];

            health[m - 1,n - 1] = Math.Max(1 - dungeon[m - 1,n - 1], 1);

            for (int i = m - 2; i >= 0; i--) {            
                health[i,n - 1] = Math.Max(health[i + 1,n - 1] - dungeon[i,n - 1], 1);
            }

            for (int j = n - 2; j >= 0; j--) {
                health[m - 1,j] = Math.Max(health[m - 1,j + 1] - dungeon[m - 1,j], 1);
            }

            for (int i = m - 2; i >= 0; i--) {
                for (int j = n - 2; j >= 0; j--) {
                    int down = Math.Max(health[i + 1,j] - dungeon[i,j], 1);
                    int right = Math.Max(health[i,j + 1] - dungeon[i,j], 1);
                    health[i,j] = Math.Min(right, down);
                }
            }

            return health[0,0];
        }

    }
}
