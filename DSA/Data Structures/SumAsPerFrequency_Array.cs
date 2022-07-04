using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA
{
    public static class SumAsPerFrequency_Array
    {
        public static void SumAsPerFrequency()
        {
            var n = 8;
            var arr = new int[] { 4, 4, 6, 5, 3, 3, 3, 9 };

            var testCases = new List<IList<int>>();
            testCases.Add(new int[] { 1, 4 });
            testCases.Add(new int[] { 2, 7 });
            testCases.Add(new int[] { 3, 7 });
            testCases.Add(new int[] { 5, 6 });

            var Q = testCases.Count;

            //foreach (var item in testCases)
            //{
            //    var arrIx = 0;
            //    var sum = 0;
            //    while (arrIx < arr.Length)
            //    {
            //        if (arr[arrIx] >= item[0] && arr[arrIx] <= item[1])
            //            sum += arr[arrIx];

            //        arrIx++;
            //    }

            //    Console.WriteLine(sum);
            //}
        }

        public static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            var distinctArr = arr.Distinct();

            //Store the frequency of elements.
            var freq = new Dictionary<int, int>();
            foreach (int i in distinctArr)
            {
                var f = arr.Where(x => x == i).Count();
                freq.Add(i, f);
            }

            var q = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < q; i++)
            {
                var queries = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp =>
                 Convert.ToInt32(arrTemp)).ToArray();
                var f = freq.Where(x => x.Value >= queries[0] && x.Value <= queries[1]);
                var sum = f.Select(x => x.Key * x.Value).Sum();
                Console.WriteLine(sum);
            }

        }
    }
}