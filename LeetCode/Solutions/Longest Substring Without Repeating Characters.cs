using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LeetCode.Longest_Substring_Without_Repeating_Characters
{
    public class Solution
    {
        //https://leetcode.com/problems/longest-substring-without-repeating-characters
        /*
         * Given a string, find the length of the longest substring without repeating characters.
         * Examples:
         * Given "abcabcbb", the answer is "abc", which the length is 3.
         * Given "bbbbb", the answer is "b", with the length of 1.
         * Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
         */

        public int LengthOfLongestSubstring(string s)
        {
            int n = s.Length, ans = 0;
            // current index of character
            Hashtable hashTable = new Hashtable();
            // try to extend the range [i, j]
            for (int j = 0, i = 0; j < n; j++)
            {
                if (hashTable.ContainsKey(s[j]))
                {
                    i = Math.Max((int)(hashTable[s[j]]), i);
                }
                ans = Math.Max(ans, j - i + 1);
                hashTable[s[j]] = j + 1;
            }
            return ans;
        }

        public void Run()
        {
            string s = "abcabcbb";
            int result = LengthOfLongestSubstring(s);
        }
    }
}
