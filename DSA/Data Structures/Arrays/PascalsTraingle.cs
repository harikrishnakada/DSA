using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA.Data_Structures.Arrays
{
    /// <summary>
    /// https://leetcode.com/problems/pascals-triangle/submissions/
    /// </summary>
    public static class PascalsTraingle
    {
        public static void Run()
        {
            int numRows = 5;
            var result = new List<IList<int>>();
            IList<int> row, pre = null;

            for (int i = 0; i < numRows; i++)
            {
                row = new List<int>();
                for (int x = 0; x <= i; ++x)
                {
                    if (x == 0 || i == x)
                        row.Add(1);
                    else
                        row.Add(pre[x - 1] + pre[x]);
                }
                pre = row;
                result.Add(row);
            }
        }
    }
}
