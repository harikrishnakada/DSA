using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Data_Structures.Arrays
{
    public static class NextPermutation
    {
        public static void Run()
        {
            var nums = new int[] { 6,2,1,5,4,3,0 };

            var isAscendingOrder = true;
            var isDecendingOrder = true;

            if (nums.Length > 1)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i + 1 < nums.Length)
                    {
                        if (nums[i] < nums[i + 1])
                        {
                            isDecendingOrder = false;
                        }
                        if (nums[i] > nums[i + 1])
                        {
                            isAscendingOrder = false;
                        }

                        if(!isAscendingOrder && !isDecendingOrder)
                        {
                            break;
                        }
                    }
                }
                int reversingStartIndex = -1;

                if (isAscendingOrder)
                {
                    var pre = nums[nums.Length - 2];
                    nums[nums.Length - 2] = nums[nums.Length - 1];
                    nums[nums.Length - 1] = pre;
                }
                else if (isDecendingOrder)
                {
                    reversingStartIndex = 0;
                }
                else
                {
                    for (int i = nums.Length - 1; i >= 0; i--)
                    {
                        if (i == 0)
                            break;

                        if (nums[i] > nums[i - 1])
                        {
                            int nextLeastGreatestElementIndex = i;

                            for (int j = i + 1; j < nums.Length; j++)
                            {
                                if (j + 1 > nums.Length)
                                    break;

                                if (nums[j] <= nums[nextLeastGreatestElementIndex] && nums[j] > nums[i - 1])
                                {
                                    nextLeastGreatestElementIndex = j;
                                }
                            }
                            var pre = nums[i - 1];
                            nums[i - 1] = nums[nextLeastGreatestElementIndex];
                            nums[nextLeastGreatestElementIndex] = pre;

                            reversingStartIndex = i;

                            break;
                        }
                    }
                }

                if (reversingStartIndex >= 0)
                {
                    int temp;
                    int start = reversingStartIndex;
                    int end = nums.Length - 1;
                    while (start < end)
                    {
                        temp = nums[start];
                        nums[start] = nums[end];
                        nums[end] = temp;
                        start++;
                        end--;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
