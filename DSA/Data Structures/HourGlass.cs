using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA.Data_Structures
{
    public static class HourGlasses
    {
        #region https://www.hackerrank.com/challenges/2d-array/problem
        public static int hourGlass(int[][] arr)
        {
            var sumCollection = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sumCollection.Add(arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]);
                }
            }
            return sumCollection.Max();
        }
        #endregion https://www.hackerrank.com/challenges/2d-array/problem
       
    }
}