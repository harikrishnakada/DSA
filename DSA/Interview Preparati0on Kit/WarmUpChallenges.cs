using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSA.Interview_Preparati0on_Kit
{
    public static class WarmUpChallenges
    {

        #region https://www.hackerrank.com/challenges/sock-merchant/problem
        public static int sockMerchant(int n, int[] arr)
        {
            int res = 0;

            var noOfColours = arr.Distinct();

            foreach (var item in noOfColours)
            {
                var noOfPairs = arr.Where(x => x == item).Count() / 2;
                res += noOfPairs;
            }

            return res;
        }
        #endregion https://www.hackerrank.com/challenges/sock-merchant/problem

        #region https://www.hackerrank.com/challenges/counting-valleys/problem
        public static int countingValleys(int n, string s)
        {
            int noOfValleys = 0;
            int seaLevel = 0;

            foreach (var item in s.ToCharArray())
            {
                if (item == 'D')
                    seaLevel--;
                else if (item == 'U')
                {
                    seaLevel++;
                    if (seaLevel == 0)
                        noOfValleys++;
                }
            }

            return noOfValleys;
        }
        #endregion https://www.hackerrank.com/challenges/counting-valleys/problem

        #region https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem
        public static int JumpingClouds(int[] arr)
        {
            int noOfJumps = 0;
            for (int i = 0; i < arr.Length; i++, noOfJumps++)
            {
                if (i < arr.Length - 2 && arr[i + 2] != 1) i++;
            }
            return noOfJumps;
        }
        #endregion https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem 


        #region https://www.hackerrank.com/challenges/repeated-string/problem
        public static long RepeatedString (long limit, String str)
        {
            long remainder = limit % str.Length;
            var noOfIterations = limit / str.Length;
            var occurances = str.Count(x => x == 'a');
            long result = (occurances * noOfIterations) + (str.Substring(0, (int)remainder).Count(x => x == 'a'));
            return result;

        }
        #endregion https://www.hackerrank.com/challenges/repeated-string/problem
    }
}
