using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Integer
{
    //https://leetcode.com/problems/reverse-integer
    /*
     * Reverse digits of an integer.
     * Example1: x = 123, return 321
     * Example2: x = -123, return -321
     * 
     * Note:
     * The input is assumed to be a 32-bit signed integer. Your function should return 0 when the reversed integer overflows.
     */

    public class Solution
    {
        public int Reverse_Self(int x)
        {
            if (x == 0 || x > int.MaxValue || x <= int.MinValue) return 0;
            Queue<int> queue = new Queue<int>();
            bool endWithZero = true;
            bool flag = x > 0;
            if (!flag) x = Math.Abs(x);
            while (x != 0)
            {
                int temp = x % 10;
                endWithZero = temp == 0 && endWithZero;
                if (!endWithZero) queue.Enqueue(temp);
                x /= 10;
            }
            string value = string.Empty;
            while (queue.Count > 0) value += queue.Dequeue();
            long result = long.Parse(value);
            result = (result > (flag ? int.MaxValue : Math.Abs((long)int.MinValue))) ? 0 : result;
            return (int)(flag ? result : -result);
        }

        public int Reverse(int x)
        {
            var rev = 0;
            while (x != 0)
            {
                try
                {
                    rev = checked(rev * 10 + x % 10);
                    x /= 10;
                }
                catch
                {
                    rev = 0;
                    break;
                }
            }
            return rev;
        }
    }
}
