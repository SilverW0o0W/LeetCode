using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Divide_Two_Integers
{
    public class Solution
    {
        //https://leetcode.com/problems/divide-two-integers/
        /*
         * Divide two integers without using multiplication, division and mod operator.
         * If it is overflow, return MAX_INT.
         */

        public int Divide_Timeout(int dividend, int divisor)
        {
            if (dividend == int.MinValue && divisor == -1) return int.MaxValue;
            bool sameSignal = (dividend > 0 && divisor > 0) || (dividend < 0 && divisor < 0);
            dividend = Math.Abs(dividend);
            divisor = Math.Abs(divisor);
            int i = 0;
            while (dividend >= divisor)
            {
                dividend -= divisor;
                i++;
            }
            i = sameSignal ? i : -i;
            return i;
        }

        //public int Divide(int dividend, int divisor)
        //{
        //    if (dividend == int.MinValue && divisor == -1) return int.MaxValue;
        //    bool sameSignal = (dividend > 0 && divisor > 0) || (dividend < 0 && divisor < 0);
        //    dividend = Math.Abs(dividend);
        //    divisor = Math.Abs(divisor);
        //    int i = RightShift(divisor, 1);
        //    i = RightShift(dividend, i);
        //    i = sameSignal ? i : -i;
        //    return i;
        //}

        //public int RightShift(int input, int num)
        //{
        //    int i = 0;
        //    while (input >= 2)
        //    {
        //        input = input >> num;
        //        i++;
        //    }
        //    return i;
        //}

        public void Run()
        {
            int dividend = 2147483647, divisor = 2;
            //int result = Divide(dividend, divisor);
        }
    }
}
