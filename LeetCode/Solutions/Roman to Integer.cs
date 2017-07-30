using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Roman_to_Integer
{
    //https://leetcode.com/problems/roman-to-integer
    /*
     * Given a roman numeral, convert it to an integer.
     * Input is guaranteed to be within the range from 1 to 3999.
     */

    public class Solution
    {
        public int RomanToInt(String s)
        {
            int res = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                char c = s[i];
                switch (c)
                {
                    case 'I':
                        res += (res >= 5 ? -1 : 1);
                        break;
                    case 'V':
                        res += 5;
                        break;
                    case 'X':
                        res += 10 * (res >= 50 ? -1 : 1);
                        break;
                    case 'L':
                        res += 50;
                        break;
                    case 'C':
                        res += 100 * (res >= 500 ? -1 : 1);
                        break;
                    case 'D':
                        res += 500;
                        break;
                    case 'M':
                        res += 1000;
                        break;
                }
            }
            return res;
        }

        public int RomanToInt_Self(string s)
        {
            int answer = 0;
            s = s.ToUpper();
            int pre = 0;
            foreach (char c in s)
            {
                int temp = CharToInt(c);
                if (pre >= temp || pre == 0)
                {
                    answer += pre;
                }
                else
                {
                    answer -= pre;
                }
                pre = temp;
            }
            answer += pre;
            return answer;
        }

        private int CharToInt(char c)
        {
            int i;
            switch (c)
            {
                case 'I':
                    i = 1;
                    break;
                case 'V':
                    i = 5;
                    break;
                case 'X':
                    i = 10;
                    break;
                case 'L':
                    i = 50;
                    break;
                case 'C':
                    i = 100;
                    break;
                case 'D':
                    i = 500;
                    break;
                case 'M':
                    i = 1000;
                    break;
                default:
                    i = 0;
                    break;
            }
            return i;
        }
    }
}
