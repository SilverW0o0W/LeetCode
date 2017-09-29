using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Generate_Parentheses
{
    public class Solution
    {
        //https://leetcode.com/problems/generate-parentheses/
        /*
         * Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
         * For example, given n = 3, a solution set is:
         * [
         *   "((()))",
         *   "(()())",
         *   "(())()",
         *   "()(())",
         *   "()()()"
         * ]
         */

        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> list = new List<string>();
            Recursion(list, string.Empty, n, n);
            return list;
        }

        public void Recursion(IList<string> list, string current, int leftRemain, int rightRemain)
        {
            if (leftRemain <= 0)
            {
                for (int i = 0; i < rightRemain; i++) current += ')';
                list.Add(current);
                return;
            }
            Recursion(list, current + '(', leftRemain - 1, rightRemain);
            if (leftRemain < rightRemain)
            {
                Recursion(list, current + ')', leftRemain, rightRemain - 1);
            }
        }

        public void Run()
        {
            IList<string> list = GenerateParenthesis(3);
        }
    }
}
