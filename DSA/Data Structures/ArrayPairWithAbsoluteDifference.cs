using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA.Data_Structures
{
    public static class ArrayPairWithAbsoluteDifference
    {
        #region https://leetcode.com/problems/count-number-of-pairs-with-absolute-difference-k/submissions/
        public static int CountKDifference(int[] nums, int k)
        {
            int diff = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == k)
                        diff++;
                }
            }
            return diff;
        }
        #endregion
    }
}