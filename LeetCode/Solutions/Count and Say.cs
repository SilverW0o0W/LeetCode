using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Count_and_Say
{
    public class Solution
    {
        //https://leetcode.com/problems/count-and-say/
        /*
         * The count-and-say sequence is the sequence of integers with the first five terms as following:
         *
         * 1.     1
         * 2.     11
         * 3.     21
         * 4.     1211
         * 5.     111221
         * 1 is read off as "one 1" or 11.
         * 11 is read off as "two 1s" or 21.
         * 21 is read off as "one 2, then one 1" or 1211.
         * Given an integer n, generate the nth term of the count-and-say sequence.
         * 
         * Note: Each term of the sequence of integers will be represented as a string.
         * 
         * Example 1:
         * 
         * Input: 1
         * Output: "1"
         * Example 2:
         * 
         * Input: 4
         * Output: "1211"
         */
        public string CountAndSay(int n)
        {
            string str = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string tempStr = string.Empty;
                if (i == 0) tempStr = "1";
                else
                {
                    bool isFirst = true;
                    int temp = 0, count = 0;

                    for (int index = 0; index < str.Length; index++)
                    {
                        int item = int.Parse(str[index].ToString());
                        if (temp == item || isFirst)
                        {
                            temp = item;
                            count++;
                            isFirst = false;
                        }
                        else
                        {
                            tempStr += count.ToString() + temp.ToString();
                            count = 0;
                            isFirst = true;
                            index--;
                        }
                    }
                    if (count != 0) tempStr += count.ToString() + temp.ToString();
                }
                str = tempStr;
            }
            return str;
        }

        public string CountAndSay_Fastest(int n)
        {
            if (n < 2) { return "1"; }
            string result = CountAndSay_Fastest(n - 1);
            return GetNextTerm(result);
        }
        private string GetNextTerm(string term)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            char prevC = '.';
            foreach (char c in term)
            {
                if (c == prevC)
                {
                    count++;
                }
                else
                {
                    if (count > 0)
                    {
                        sb.Append(count);
                        sb.Append(prevC);
                    }
                    prevC = c;
                    count = 1;
                }
            }
            if (count > 0)
            {
                sb.Append(count);
                sb.Append(prevC);
            }
            return sb.ToString();
        }

        public void Run()
        {
            int i = 4;
            string result = CountAndSay(i);
        }
    }
}
