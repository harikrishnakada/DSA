using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Data_Structures.Arrays
{

    /// <summary>
    /// https://leetcode.com/problems/set-matrix-zeroes/submissions/
    /// </summary>
    public static class SetMatrixZeros
    {
        public static void Run()
        {
            var matrix = new int[][] { new int[] { 1, 1, 1, 1 }, new int[] { 1, 0, 1, 1 }, new int[] { 1, 1, 0, 0 }, new int[] { 0, 0, 0, 1 } };

            int rows = matrix.Length, cols = matrix[0].Length, col0 = 1;

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i][0] == 0)
                {
                    col0 = 0;
                }
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }

            for (int i = rows - 1; i >= 0; i--)
            {
                for (int j = cols - 1; j >= 1; j--)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    {
                        matrix[i][j] = 0;
                    }
                }
                if (col0 == 0)
                {
                    matrix[i][0] = 0;
                }
            }

            //print output
            Console.WriteLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i][j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
