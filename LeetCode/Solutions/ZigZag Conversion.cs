using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ZigZag_Conversion
{
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;
            int n = numRows - 1;
            int loopNum = 2 * n;
            int maxLine = (s.Length - 1) / loopNum;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j <= maxLine; j++)
                {
                    int index = loopNum * j + i;
                    if (index < s.Length)
                    {
                        sb.Append(s[index]);
                    }
                    else
                    {
                        break;
                    }
                    if (i == 0 || i == n)
                    {
                        continue;
                    }
                    index = loopNum * (j + 1) - i;
                    if (index < s.Length)
                    {
                        sb.Append(s[index]);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return sb.ToString();
        }

        public void Run()
        {
            string s = "PAYPALISHIRING";
            int numRows = 3;
            string result = Convert(s, numRows);
        }
    }
}
