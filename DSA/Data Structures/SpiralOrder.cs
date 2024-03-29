﻿using System;
using System.Collections.Generic;

namespace DSA.Data_Structures
{
    public static class SpiralOrder_MultiDimentionalArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }

        //int[][] b = new int[][]{
        //                new int[] { 1, 2, 3, 4 },
        //                new int[] { 5, 6, 7, 8},
        //                new int[] { 9, 10, 11, 12 }
        //            };
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            var R = matrix.Length;
            var C = matrix[0].Length;
            bool[,] visited = new bool[R, C];
            var output = "";
            var strList = new List<int>();
            var start = -1;
            var matrixLength = R * C;

            while (strList.Count != matrixLength)
            {
                start++;
                //Left to right
                for (int i = start; i < C; i++)
                {
                    if (visited[start, i] == false)
                    {
                        output = $"{output} {matrix[start][i]}";
                        strList.Add(matrix[start][i]);
                        visited[start, i] = true;
                    }
                }

                //Right to bottom
                for (int i = start; i < R; i++)
                {
                    if (visited[i, C - 1] == false)
                    {
                        output = $"{output} {matrix[i][C - 1]}";
                        strList.Add(matrix[i][C - 1]);
                        visited[i, C - 1] = true;
                    }
                }

                //Bottom to left
                for (int i = C - 1; i >= start; i--)
                {
                    if (visited[R - 1, i] == false)
                    {
                        output = $"{output} {matrix[R - 1][i]}";
                        strList.Add(matrix[R - 1][i]);
                        visited[R - 1, i] = true;
                    }
                }

                //Lleft to top
                for (int i = R - 1; i >= start; i--)
                {
                    if (visited[i, start] == false)
                    {
                        output = $"{output} {matrix[i][start]}";
                        strList.Add(matrix[i][start]);
                        visited[i, 0] = true;
                    }
                }
                C--;
                R--;
            }
            return strList;
        }
    }
}