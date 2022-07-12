using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Algorithms.BinarySearch
{
    public class BinarySearch
    {
        public static int Run()
        {
            var nums = new int[] { 1,2 };
            var target = 2;
            int i = 0;

            int lowerBound = 0;
            int upperBound = nums.Length - 1;
            int midPoint = -1;
            while (lowerBound <= upperBound)
            {
                midPoint = lowerBound + (upperBound - lowerBound) / 2;

                if (nums[midPoint] > target)
                {
                    upperBound = midPoint - 1;

                }
                else if (nums[midPoint] < target)
                {
                    lowerBound = midPoint + 1;
                }
                else
                {
                    return midPoint;
                }
            }

            return -1;
        }
    }
}
