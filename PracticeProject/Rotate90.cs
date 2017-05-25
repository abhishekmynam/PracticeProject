using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class Rotate90
    {
        public void rotate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i; j < matrix.GetLength(1); j++)
                {
                    int temp = 0;
                    temp = matrix[i,j];
                    matrix[i,j] = matrix[j,i];
                    matrix[j,i] = temp;
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0) / 2; j++)
                {
                    int temp = 0;
                    temp = matrix[i,j];
                    matrix[i,j] = matrix[i,matrix.GetLength(0)- 1 - j];
                    matrix[i,matrix.GetLength(0) - 1 - j] = temp;
                }
            }
        }
    }
}
