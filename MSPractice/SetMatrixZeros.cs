using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    public class SetMatrixZeros
    {
        public void SetZeroes(int[,] matrix)
        {
            HashSet<int> col = new HashSet<int>();
            HashSet<int> row = new HashSet<int>();

            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0) 
                    {
                        col.Add(j);
                        row.Add(i);
                    }
                }
            }
            for (int i = 0; i < row.Count(); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[row.ElementAt(i), j] = 0;
                }
            }

            for (int i = 0; i < col.Count(); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[j, col.ElementAt(i)] = 0;
                }
            }
            
        }
    }
}
