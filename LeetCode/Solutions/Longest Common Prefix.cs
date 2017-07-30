using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Longest_Common_Prefix
{
    public class Solution
    {
        //https://leetcode.com/problems/longest-common-prefix/
        /*
         * Write a function to find the longest common prefix string amongst an array of strings.
         */

        public string LongestCommonPrefix_Self(string[] strs)
        {
            string minString = string.Empty;
            int minLength = int.MaxValue;
            minString = string.Empty;
            string prefix = string.Empty;
            foreach (string str in strs)
            {
                if (str.Length < minLength)
                {
                    minLength = str.Length;
                    minString = str;
                }
            }
            string result = GetPrefix(strs, minString, 0, minString.Length);
            return result;
        }

        private string GetPrefix(string[] strs, string minString, int prefixLength, int change)
        {
            if (change == 0 || prefixLength == minString.Length)
            {
                return minString.Substring(0, prefixLength);
            }

            bool isCommonPrefix = true;
            string input = minString.Substring(0, prefixLength + change);
            foreach (string str in strs)
            {
                if ((str.Length <= input.Length && str != input) || !str.StartsWith(input))
                {
                    isCommonPrefix = false;
                    break;
                }
            }
            if (isCommonPrefix)
            {
                prefixLength = input.Length;
            }
            change = change % 2 == 0 || change == 1 ? change / 2 : (change + 1) / 2;
            return GetPrefix(strs, minString, prefixLength, change);
        }

        public void Run()
        {

        }
    }
}
