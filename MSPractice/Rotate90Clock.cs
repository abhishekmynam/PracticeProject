using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class Rotate90Clock
    {
        public void rotate(int[,] matrix) 
        {
            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for (int j = i; j < matrix.GetLength(1); j++) 
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0)/2; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, matrix.GetLength(0) - 1 - j];
                    matrix[i, matrix.GetLength(0) - 1 - j] = temp;
                }
            }
        }
    }
}
