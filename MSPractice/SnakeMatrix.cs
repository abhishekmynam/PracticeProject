using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    public class SnakeMatrix
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            int R = matrix.GetLength(0);
            int C = matrix.GetLength(1);
            int[] resList = new int[R * C];
            int startVal=0, endVal=0, addVal=1, k=0;
            bool flag = true, turn = true;

            for (int i = 0; i < R; i++)
            {
                
                for (int j = startVal; flag ; j= j+addVal)
                {
                    resList[k] = matrix[i, j];
                    k++;
                    if (turn) { flag = j + addVal < C; }
                    else { flag = j + addVal >= 0; }
                }
                if (startVal == 0)
                {
                    startVal = C - 1;
                    endVal = 0;
                    addVal = -1;
                    flag = true;
                    turn = false;
                }
                else 
                {
                    startVal = 0;
                    endVal = C;
                    addVal = 1;
                    flag = true;
                    turn = true;
                }
            }
            return resList;
        }
    }
}
