using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Length_Of_Last_Word
{
    public class Solution
    {
        //https://leetcode.com/problems/length-of-last-word/
        /*
         * Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.
         * If the last word does not exist, return 0.
         * Note: A word is defined as a character sequence consists of non-space characters only.
         * Example:
         * Input: "Hello World"
         * Output: 5
         */
        public int LengthOfLastWord(string s)
        {
            int i;
            int last_space = 0;
            bool last = true;
            for (i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    if (last)
                    {
                        last_space++;
                        continue;
                    }
                    else
                        break;
                }
                last = false;
            }
            return s.Length - i - last_space - 1;
        }

        public void Run()
        {
            string str = "hello world";
            int result = LengthOfLastWord(str);
        }
    }
}