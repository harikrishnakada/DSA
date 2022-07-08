using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Data_Structures.Arrays
{
    public static class NextPermutation
    {
        public static void Run()
        {
            var nums = new int[] { 2, 3, 1, 3, 3, 3 };

            var isTouched = false;

            if (nums.Length > 1)
            {
                for (int i = nums.Length - 1; i >= 0; i--)
                {
                    if (i == 0)
                        break;

                    if (nums[i] > nums[i - 1])
                    {
                        isTouched = true;
                        reverse(nums, i, nums.Length - 1);

                        for (int j = i; j < nums.Length; j++)
                        {
                            if (nums[j] > nums[i - 1])
                            {
                                swap(nums, i - 1, j);
                                break;
                            }
                        }
                        break;
                    }
                }

                if (!isTouched)
                {
                    reverse(nums, 0, nums.Length - 1);
                }
            }
            Console.WriteLine(String.Join(" ", nums));
        }
        public static void reverse(int[] nums, int start, int end)
        {
            int temp;
            while (start < end)
            {
                temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
        public static void swap(int[] nums, int source, int target)
        {
            var pre = nums[source];
            nums[source] = nums[target];
            nums[target] = pre;
        }
    }
}
