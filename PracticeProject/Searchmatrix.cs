using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class Searchmatrix
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            int col=0, row=0;
            while (col < matrix.GetLength(0) && row < matrix.GetLength(1)) 
            {
                if (matrix[col, row] == target) { return true; }
                else if (matrix[col, row] < target)
                {
                    if (matrix.GetLength(0) == col + 1) { row++; }
                    else if (matrix.GetLength(1) == row + 1) { col++; }
                    else { col++; row++; }
                }
                else if (matrix[col, row] < target)
                {
                    int i = col - 1;
                    while (i < matrix.GetLength(0))
                    {
                        if (matrix[i, row] == target) { return true; }
                        else if (matrix[i, row] < target) { i++; }
                        else if (matrix[i, row] > target) { break; }
                    }
                    i = row - 1;
                    while (i < matrix.GetLength(1))
                    {
                        if (matrix[col, i] == target) { return true; }
                        else if (matrix[col, i] < target) { i++; }
                        else if (matrix[col, i] > target) { return false; }
                    }

                }
            }
            return false;
        }
    }
}
