using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Multiply_Strings
{
    public class Solution
    {
        //https://leetcode.com/problems/multiply-strings/
        /*
         * Given two non-negative integers num1 and num2 represented as strings, return the product of num1 and num2, also represented as a string.
         * Example 1:
         * Input: num1 = "2", num2 = "3"
         * Output: "6"
         * Example 2:
         * Input: num1 = "123", num2 = "456"
         * Output: "56088"
         * Note:
         * The length of both num1 and num2 is < 110.
         * Both num1 and num2 contain only digits 0-9.
         * Both num1 and num2 do not contain any leading zero, except the number 0 itself.
         * You must not use any built-in BigInteger library or convert the inputs to integer directly.
         */

        public string Multiply(string num1, string num2)
        {
            var r = new int[num1.Length + num2.Length];

            for (var i = num1.Length - 1; i >= 0; --i)
                for (var j = num2.Length - 1; j >= 0; --j)
                    r[i + j + 1] += (num1[i] - '0') * (num2[j] - '0');

            for (var i = r.Length - 1; i > 0; --i)
            {
                r[i - 1] += r[i] / 10;
                r[i] %= 10;
            }

            var sb = new StringBuilder();
            for (var i = 0; i < r.Length; ++i)
            {
                if (sb.Length > 0 || r[i] != 0 || i == r.Length - 1)
                    sb.Append((char)('0' + r[i]));
            }

            return sb.ToString();
        }

        public string Multiply_Self(string num1, string num2)
        {
            if (num1.Equals("0") || num2.Equals("0")) return "0";
            int[] nums = new int[num1.Length + num2.Length];
            for (int i = 0; i < num1.Length; i++)
            {
                for (int j = 0; j < num2.Length; j++)
                {
                    string n1 = num1[num1.Length - i - 1].ToString();
                    string n2 = num2[num2.Length - j - 1].ToString();
                    nums[i + j] += int.Parse(n1) * int.Parse(n2);
                }
            }
            char[] result = new char[nums.Length];
            int last = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int value = nums[i] + last;
                result[i] = Convert.ToChar(value % 10 + 48);
                last = value / 10;
            }
            Array.Reverse(result);
            return new string(result).TrimStart('0');
        }

        public void Run()
        {
            string num1 = "123", num2 = "456";
            string result = Multiply(num1, num2);
        }
    }
}
