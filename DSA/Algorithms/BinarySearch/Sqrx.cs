using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Algorithms.BinarySearch
{
    public static class Sqrx
    {
        public static int Run()
        {
            int num = 2147395599;
            long l = 1, h = num / 2, m = -1;
            long ans = -1;

            if (num == 1)
                return 1;


            while (l <= h)
            {
                m = l + (h - l) / 2;
                long sqr = m * m;

                if (num < sqr)
                {
                    h = m - 1;
                }
                else if (num > sqr)
                {
                    ans = m;
                    l = m + 1;
                }
                else
                {
                    ans = m;
                    break;
                }
            }

            Console.WriteLine(ans);
            return Convert.ToInt32(ans);
        }
    }
}
