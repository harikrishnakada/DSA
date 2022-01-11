using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA.Data_Structures
{
    public static class LeftRotations
    {
        #region https://www.hackerrank.com/challenges/array-left-rotation/problem

        public static int[] leftRotations(int[] arr, int leftRotations)
        {
            int temp;
            int start = 0;
            int end = arr.Length - 1;

            while (start < leftRotations)
            {
                int first = arr[0];
                int j = 0;
                while (j < end)
                {
                    arr[j] = arr[j + 1];
                    j++;
                }
                arr[end] = first;
                start++;
            }
            Console.Write(string.Join(" ", arr));
            return arr;
        }

        public static int[] leftRotationsOptimised(int[] arr, int leftRotations)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[(i + arr.Length - leftRotations) % arr.Length] = arr[i];
            }
            Console.Write(string.Join(" ", arr));

            return arr;
        }

        #endregion https://www.hackerrank.com/challenges/array-left-rotation/problem
        
    }
}