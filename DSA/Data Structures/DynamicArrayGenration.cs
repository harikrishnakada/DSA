using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA.Data_Structures
{
    public static class DynamicArrayGenration
    {
        #region https://www.hackerrank.com/challenges/dynamic-array/problem
        public static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            var res = new List<int>();

            var dynamicSequence = new List<List<int>>();
            for (int i = 0; i < n; i++)
                dynamicSequence.Add(new List<int>());

            int lastAnswer = 0;

            foreach (var item in queries)
            {
                int x = item[1];
                int y = item[2];
                int seq = ((x ^ lastAnswer) % n);
                if (item[0] == 1)
                {
                    dynamicSequence[seq].Add(y);
                }
                else if (item[0] == 2)
                {
                    lastAnswer = dynamicSequence[seq][y % dynamicSequence[seq].Count()];
                    res.Add(lastAnswer);
                }

            }

            return res;
        }
        #endregion https://www.hackerrank.com/challenges/dynamic-array/problem
    }
}