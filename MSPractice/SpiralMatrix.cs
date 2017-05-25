using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class SpiralMatrix
    {
        public IList<int> SpiralOrder(int[,] matrix) 
        {
            IList<int> list = new List<int>();
            if (matrix.GetLength(0) == 0) return list;

            int m = matrix.GetLength(1); //width
            int n = matrix.GetLength(0); //height
            int x = 0, y = 0;

            while (m > 0 && n > 0)
            {
                //If there is only one row or one column, then just put this row/column into the list
                if (m == 1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        list.Add(matrix[x,y++]);
                    }
                    break;
                }
                else if (n == 1)
                {
                    for (int i = 0; i < m; i++)
                    {
                        list.Add(matrix[x++,y]);
                    }
                    break;
                }

                //left to right
                for (int i = 0; i < n - 1; i++)
                {
                    list.Add(matrix[x,y++]);
                }

                //up to down
                for (int i = 0; i < m - 1; i++)
                {
                    list.Add(matrix[x++,y]);
                }

                //right to left
                for (int i = 0; i < n - 1; i++)
                {
                    list.Add(matrix[x,y--]);
                }

                //down to up
                for (int i = 0; i < m - 1; i++)
                {
                    list.Add(matrix[x--,y]);
                }

                m = m - 2;
                n = n - 2;
                x++;
                y++;
            }
            return list;
        }
    }
}
