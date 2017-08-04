using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Longest_Palindromic_Substring
{
    public class Solution
    {
        //https://leetcode.com/problems/longest-palindromic-substring
        /*
         * Given a string s, find the longest palindromic substring in s.You may assume that the maximum length of s is 1000.
         * Example:
         *   Input: "babad"
         *   Output: "bab"
         * Note: "aba" is also a valid answer.
         * Example:
         *   Input: "cbbd"
         *   Output: "bb"
         */

        //Better way.
        //http://articles.leetcode.com/longest-palindromic-substring-part-ii/

        public string LongestPalindrome(string s)
        {
            int start = 0;
            int end = 0;
            int length = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int length1 = ExpandAroundCenter(s, i, i);
                int length2 = ExpandAroundCenter(s, i, i + 1);
                length = Math.Max(length1, length2);
                if (length > end - start)
                {
                    start = i - (length - 1) / 2;
                    end = i + length / 2;
                }
            }
            return s.Substring(start, end - start + 1);
        }

        private int ExpandAroundCenter(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }

        public void Run()
        {
            string input = "babad";
            string output = LongestPalindrome(input);
        }
    }
}
