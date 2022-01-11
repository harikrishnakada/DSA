using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA.Data_Structures
{
    public static class ArrayCrush
    {
        #region https://www.hackerrank.com/challenges/crush/problem
        //This solution uses the Prefix sum array alogrithm.
        public static long arrayManipulation(int n, int[][] queries)
        {
            long maxNum = 0;
            long temp = 0;

            long[] arr = new long[n];

            foreach (var item in queries)
            {
                int a = item[0];
                int b = item[1];
                int k = item[2];
                arr[a - 1] += k;

                //In order to apply the application of Prefix sum array alogrithm, add the value of -k at position b.
                if (b <= arr.Length - 1)
                    arr[b] += -k;
            }

            maxNum = arr.Max();

            for (int i = 0; i < n; i++)
            {
                temp += arr[i];

                maxNum = temp > maxNum ? temp : maxNum;
            }

            return maxNum;
        }
        #endregion https://www.hackerrank.com/challenges/crush/problem

    }
}