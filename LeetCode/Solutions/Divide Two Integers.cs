﻿using System;
using System.Collections;
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

        public int Divide(int dividend, int divisor)
        {
            if (dividend == int.MinValue && divisor == -1) return int.MaxValue;
            bool sign = (dividend < 0) ^ (divisor < 0);
            long dvd = Math.Abs((long)dividend);
            long dvs = Math.Abs((long)divisor);
            long res = 0;
            while (dvd >= dvs)
            {
                long temp = dvs, multiple = 1;
                while (dvd >= (temp << 1))
                {
                    temp <<= 1;
                    multiple <<= 1;
                }
                dvd -= temp;
                res += multiple;
            }
            return (int)(sign ? -res : res);
        }

        //public int Divide_Improve(int dividend, int divisor)
        //{
        //    if (dividend == int.MinValue && divisor == -1) return int.MaxValue;
        //    int sign = ((dividend < 0) ^ (divisor < 0)) ? -1 : 1;
        //    long dvd = Math.Abs((long)dividend);
        //    long dvs = Math.Abs((long)divisor);
        //    long res = 0;
        //    bool isFirst = true;
        //    Hashtable caches = new Hashtable();
        //    while (dvd >= dvs)
        //    {
        //        long temp = dvs, multiple = 1;
        //        if (isFirst)
        //        {
        //            while (dvd >= (temp << 1))
        //            {
        //                temp <<= 1;
        //                multiple <<= 1;
        //                caches.Add(multiple, temp);
        //            }
        //            isFirst = false;
        //        }
        //        else
        //        {
        //            while (true)
        //            {
        //                if (!(dvd >= (long)caches[multiple << 1])) break;
        //                multiple <<= 1;
        //            }
        //        }
        //        dvd -= temp;
        //        res += multiple;
        //    }
        //    return (int)(sign == 1 ? res : -res);
        //}

        public void Run()
        {
            int dividend = 2147483647, divisor = 1;
            int result = Divide(dividend, divisor);
        }
    }
}
