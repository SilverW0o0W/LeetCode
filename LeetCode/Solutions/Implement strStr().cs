using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Implement_strStr
{
    public class Solution
    {
        //https://leetcode.com/problems/implement-strstr
        /*
         * Implement strStr().
         * Returns the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
         */
        public int StrStr(string haystack, string needle)
        {
            for (int i = 0; ; i++)
            {
                for (int j = 0; ; j++)
                {
                    if (j == needle.Length) return i;
                    if (i + j == haystack.Length) return -1;
                    if (needle[j] != haystack[i + j]) break;
                }
            }
        }

        public void Run()
        {
            int result = StrStr("abcdecd", "cd");
        }
    }
}
