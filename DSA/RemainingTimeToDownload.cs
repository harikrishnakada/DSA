using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class RemainingTimeToDownload
    {
        public static void Run()
        {

        }

        public static int solution1(int X, int[] B, int Z)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            float remainingTime = 0;
            int totalBytesDownloaded = 0;
            int remainingBytes = 0;
            float averageTime = 0f;

            if (B.Length == 0 || X <= 0)
            {
                return -1;
            }

            for (int i = 0; i < B.Length; i++)
            {
                totalBytesDownloaded += B[i];

                if (i >= B.Length - Z || Z <= 0 || Z >= B.Length)
                {
                    float denom = Z <= 0 || Z >= B.Length ? B.Length : Z;
                    averageTime += (B[i] / denom);
                }
            }

            if (X == totalBytesDownloaded)
            {
                return 0;
            }
            else if (X < totalBytesDownloaded)
            {
                return -1;
            }

            remainingBytes = X - totalBytesDownloaded;

            remainingTime = remainingBytes / averageTime;

            return (int)Math.Ceiling(remainingTime);
        }
    }
}
