using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

using DSA.Algorithms.BinarySearch;
using DSA.Data_Structures;
using DSA.Data_Structures.Arrays;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static void swapper(int[] arr, int startIndex)
        {
            int tempI = 0;
            while (startIndex < arr.Length)
            {
                int temp = arr[tempI];
                arr[tempI] = arr[startIndex];
                arr[startIndex] = temp;

                tempI++;
                startIndex++;
            }
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

        public static void Run()
        {
            int[] arr = new int[] { -1, -3, 0, 2 };
            int num = 0;
            arr = arr.OrderBy(x => x).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] >= 0)
                {
                    if (i == arr.Length - 1)
                    {
                        num = arr[i] + 1;
                        break;
                    }

                    if (arr[i + 1] - arr[i] > 1)
                    {
                        num = arr[i] + 1;
                        break;
                    }
                }
            }
            if (num == 0)
                num++;
            Console.WriteLine(num);


        }

        private static void Spaces()
        {
            var r = "thisishari";
            var s = new String(r.Reverse().ToArray());

            int[] spaces = new int[] { 4, 6 };
            var sb = new StringBuilder();
            var start = 0;
            var end = spaces[0];
            for (int i = 0; i < spaces.Length; i++)
            {
                var subs = r.Substring(start, end);
                sb.Append(subs);
                sb.Append(" ");
                start = spaces[i];
                end = i + 1 > spaces.Length - 1 ? r.Length - 1 : spaces[i + 1] - spaces[i];
            }
        }
    }
}
