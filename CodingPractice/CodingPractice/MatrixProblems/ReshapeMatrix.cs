using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.MatrixProblems
{
    public static class ReshapeMatrix
    {
        public static int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int matRows = mat.Length;
            int matCols = mat[0].Length;

            int[][] resultMatrix = new int[r][];

            if(matRows * matCols != r * c)
            {
                return mat;
            }

            for(int i=0;i<r;i++)
            {
                resultMatrix[i] = new int[c];
            }

            var currentRow = 0;
            var currentCol = 0;

            for(int i=0;i<matRows;i++)
            {
                for(int j=0;j<matCols;j++)
                {
                    if(!(currentCol< c))
                    {
                        currentRow++;
                        currentCol = 0;
                    }

                    resultMatrix[currentRow][currentCol] = mat[i][j];
                    currentCol++;
                }
            }

            return resultMatrix;
        }
    }
}
