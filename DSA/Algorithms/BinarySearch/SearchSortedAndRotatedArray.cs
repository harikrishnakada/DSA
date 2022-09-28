using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Algorithms.BinarySearch
{
    public class SearchSortedAndRotatedArray
    {
        public static int Run()
        {
            var nums = new int[] { 3, 1 };
            int target = 1;
            int res = -1;

            int l = 0, h = nums.Length - 1, m = -1;

            while (l <= h)
            {
                m = l + (h - l) / 2;

                if (nums[m] == target)
                {
                    res = m;
                    break;
                }
                if (nums[l] <= nums[m])
                {
                    if (nums[l] <= target && nums[m] > target)
                    {
                        h = m - 1;
                    }
                    else
                    {
                        l = m + 1;
                    }
                }
                else
                {
                    if (nums[m] < target && target <= nums[h])
                    {
                        l = m + 1;
                    }
                    else
                    {
                        h = m - 1;
                    }
                }
            }
            return res;
        }

        public static int Run2()
        {
            var nums = new int[] { 5, 1, 2, 3, 4 };
            int target = 1;

            int l = 0, h = nums.Length - 1, m = -1, res = -1;

            while (l <= h)
            {
                m = l + (h - l) / 2;

                if (nums[l] <= nums[m])
                {
                    if(target > nums[m])
                    {
                        l = m + 1;
                    }
                    else
                    {
                        h = m - 1;
                    }
                }
                else
                {
                    
                }
            }

            return res;
        }

    }
}
