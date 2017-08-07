using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Regular_Expression_Matching
{
    public class Solution
    {
        public bool IsMatch(string s, string p)
        {
            Queue<char> pattern = new Queue<char>(p);
            bool isRepeat = false;
            char preMatch = '.';
            for (int i = 0; i < s.Length; i++)
            {
                char tempPattern;
                if (preMatch == '.' && isRepeat)
                {
                    tempPattern = '.';
                }
                else if (pattern.Count > 0)
                {
                    tempPattern = pattern.Dequeue();
                }
                else if (isRepeat)
                {
                    tempPattern = preMatch;
                }
                else
                {
                    return false;
                }
                if (pattern.Count > 0 && pattern.Peek() == '*')
                {
                    pattern.Dequeue();
                    preMatch = tempPattern;
                    isRepeat = true;
                }
                if (s[i] != tempPattern && tempPattern != '.')
                {
                    if (isRepeat)
                    {
                        i = i == 0 ? i : i - 1;
                    }
                    else
                    {
                        return false;
                    }
                }
                if (tempPattern != s[i] && tempPattern != '.')
                {
                    isRepeat = false;
                }
                preMatch = tempPattern == '.' ? '.' : s[i];
            }

            while (pattern.Count > 0 && pattern.Count % 2 == 0)
            {
                pattern.Dequeue();
                if (pattern.Count == 0) return false;
                if (pattern.Peek() != '*')
                {
                    break;
                }
                else
                {
                    pattern.Dequeue();
                }
            }

            return pattern.Count == 0;
        }

        public void Run()
        {
            string input = "bbbba";
            string pattern = ".*a*a";
            bool result = IsMatch(input, pattern);
        }
    }
}
