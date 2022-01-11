using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //NewMethod();
            SumAsPerFrequency();
        }
        private static void SumAsPerFrequency()
        {
            var n = 8;
            var arr = new int[] { 4, 4, 6, 5, 3, 3, 3, 9 };

            var testCases = new List<IList<int>>();
            testCases.Add(new int[] { 1, 4 });
            testCases.Add(new int[] { 2, 7 });
            testCases.Add(new int[] { 3, 7 });
            testCases.Add(new int[] { 5, 6 });

            var Q = testCases.Count;

            foreach (var item in testCases)
            {
                var arrIx = 0;
                var sum = 0;
                while (arrIx < arr.Length)
                {
                    if (arr[arrIx] >= item[0] && arr[arrIx] <= item[1])
                        sum += arr[arrIx];

                    arrIx++;
                }

                Console.WriteLine(sum);
            }
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
