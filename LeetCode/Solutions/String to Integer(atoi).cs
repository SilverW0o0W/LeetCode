using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String_to_Integer
{
    public class Solution
    {
        public int MyAtoi_Self(string str)
        {
            bool isStart = false;
            bool isPositive = true;
            long value = 0;
            foreach (char c in str)
            {
                long tempValue = Check(c);
                if (tempValue > -1)
                {
                    if (tempValue > 9)
                    {
                        if (!isStart)
                        {
                            isStart = true;
                            isPositive = tempValue == 11;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        tempValue = value * 10 + tempValue;
                        if (isPositive)
                        {
                            if (tempValue > int.MaxValue)
                            {
                                value = int.MaxValue;
                                break;
                            }
                        }
                        else
                        {
                            if (-tempValue < int.MinValue)
                            {
                                value = int.MinValue;
                                isPositive = true;
                                break;
                            }
                        }
                        value = tempValue;
                    }
                    isStart = true;
                }
                else if (isStart || tempValue != -1)
                {
                    break;
                }
            }
            return (int)(isPositive ? value : -value);
        }

        private int Check(char c)
        {
            switch (c)
            {
                case '0': return 0;
                case '1': return 1;
                case '2': return 2;
                case '3': return 3;
                case '4': return 4;
                case '5': return 5;
                case '6': return 6;
                case '7': return 7;
                case '8': return 8;
                case '9': return 9;
                case '-': return 10;
                case '+': return 11;
                case ' ': return -1;
                default: return -2;
            }
        }

        public void Run()
        {
            //string value = "-2147483649";
            string value = "23a8f";
            int result = MyAtoi_Self(value);
        }
    }
}
