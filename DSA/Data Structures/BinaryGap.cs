using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Data_Structures
{
    public class BinaryGap
    {
        public static void Run()
        {
            int num = 15;
            var binaryS = Convert.ToString(num, 2);
            int binaryGap = 0;
            int preBinaryIndex = 0;
            int maxBinaryGap = 0;
            for (int i = 1; i < binaryS.Length; i++)
            {
                if (binaryS[i] == '1' && binaryS[preBinaryIndex] == '1')
                {
                    binaryGap = (i - 1) - (preBinaryIndex);
                    preBinaryIndex = i;

                    if (binaryGap > maxBinaryGap)
                        maxBinaryGap = binaryGap;
                }
            }
            Console.WriteLine(maxBinaryGap);
        }
    }
}
