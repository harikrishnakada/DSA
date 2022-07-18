using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Algorithms.BinarySearch
{
    public class FindMinInSortedRotatedArray
    {
        public static int Run()
        {
            var nums = new int[] { 2, 1 };

            int l = 0, h = nums.Length - 1, m = -1, res = -1;

            if (nums.Length == 1)
                return nums[0];

            while (l <= h)
            {
                m = l + (h - l) / 2;

                if (nums[l] <= nums[m] && nums[m] <= nums[h])
                {
                    res = nums[l];
                    break;
                }

                if ((m > 0 && nums[m] < nums[m - 1]))
                {
                    res = nums[m];
                    break;
                }


                if (nums[l] <= nums[m])
                {
                    l = m + 1;
                }
                else
                {
                    h = m - 1;
                }
            }

            Console.WriteLine(res);

            return res;
        }
    }
}
