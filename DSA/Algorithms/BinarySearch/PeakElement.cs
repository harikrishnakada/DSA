using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Algorithms.BinarySearch
{
    public static class PeakElement
    {
        public static int Run()
        {
            var nums = new int[] { 3, 2, 1 };

            int l = 0, h = nums.Length - 1, m = -1, ans = -1;


            while (l <= h)
            {
                if (nums.Length == 1)
                {
                    ans = 0;
                    break;
                }

                m = l + (h - l) / 2;

                if (m == nums.Length - 1)
                {
                    ans = nums[m - 1] > nums[m] ? m - 1 : m;
                    break;
                }
                else if (m == 0)
                {
                    ans = nums[m + 1] > nums[m] ? m + 1 : m;
                    break;
                }
                else
                {
                    if (nums[m] > nums[m - 1] && nums[m] > nums[m + 1])
                    {
                        ans = m;
                        break;
                    }
                    else if (nums[m - 1] >= nums[m + 1])
                    {
                        h = m - 1;
                    }
                    else if (nums[m + 1] >= nums[m - 1])
                    {
                        l = m + 1;
                    }
                }

            }

            return ans;
        }
    }
}
