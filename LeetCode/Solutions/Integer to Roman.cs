using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Integer_to_Roman
{
    public class Solution
    {
        //https://leetcode.com/problems/integer-to-roman/
        /*
         * Given an integer, convert it to a roman numeral.
         * Input is guaranteed to be within the range from 1 to 3999.
         */

        public string IntToRoman(int num)
        {
            if (1 > num || num > 3999) return string.Empty;
            String[] M = { "", "M", "MM", "MMM" };
            String[] C = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            String[] X = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            String[] I = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            return M[num / 1000] + C[(num % 1000) / 100] + X[(num % 100) / 10] + I[num % 10];
        }

        public void Run()
        {
            string result = IntToRoman(3999);
        }
    }
}