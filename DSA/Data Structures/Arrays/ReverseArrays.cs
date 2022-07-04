using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA.Data_Structures.Arrays
{
    public static class ReverseArrays
    {
        
        #region https://www.hackerrank.com/challenges/arrays-ds/problem

        public static int[] reverseArrayUisngLinq(int[] arr)
        {
            return arr.Reverse().ToArray();
        }

        public static int[] reverseIntArrayUsingLogic(int[] arr)
        {
            int temp;
            int start = 0;
            int end = arr.Length - 1;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }

            return arr;
        }

        #endregion https://www.hackerrank.com/challenges/arrays-ds/problem

    }
}