using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Algorithms.BinarySearch
{
    public static class FirstLastOccuranceOfX
    {
        public static int[] Run()
        {
            var nums = new int[] { 0, 1, 2, 3, 4, 5, 5, 5, 5 };
            int target = 5;

            var res = new int[2] { -1, -1 };

            res[0] = BSearch(nums, target, true);
            res[1] = BSearch(nums, target, false);

            
            Console.WriteLine($"{res[0]} , {res[1]}");

            return res;
        }

        public static int BSearch(int[] nums, int target, bool isForFirstOccurance)
        {
            int l = 0, h = nums.Length - 1, m = -1, ans = -1;

            while (l<=h)
            {
                m = l + (h - l) / 2;

                if(target > nums[m])
                {
                    l = m + 1;
                }else if(target < nums[m])
                {
                    h = m - 1;
                }
                else
                {
                    ans = m;
                    if (isForFirstOccurance)
                    {
                        h = m - 1;
                    }
                    else
                    {
                        l = m + 1;
                    }
                }
            }

            return ans;
        }

    }
}
