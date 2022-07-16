using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Data_Structures
{
    public class ValidPalindrome
    {
        public static void Run()
        {
            var s = "atbbga";
            int l = 0, h = s.Length - 1;

            bool isMatched = true;
            while (l < h)
            {
                if (s[l] != s[h])
                {
                    isMatched = CheckPalindrome(s, l + 1, h);
                    if (!isMatched)
                        isMatched = CheckPalindrome(s, l, h - 1);
                    break;
                }
                h--;
                l++;
            }

            Console.WriteLine(isMatched);
        }

        public static bool CheckPalindrome(string s, int i, int j)
        {
            while (i < j)
            {
                if (s[i] != s[j])
                    return false;

                i++;
                j--;
            }
            return true;
        }
    }
}
