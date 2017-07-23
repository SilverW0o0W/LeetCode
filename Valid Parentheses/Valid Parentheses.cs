using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Parentheses
{
    //https://leetcode.com/problems/valid-parentheses
    /*
     * Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
     * The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not. 
     */
    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                switch (c)
                {
                    case '(':
                        stack.Push(')');
                        break;
                    case '[':
                        stack.Push(']');
                        break;
                    case '{':
                        stack.Push('}');
                        break;
                    case ')':
                    case ']':
                    case '}':
                        if (stack.Count < 1 || stack.Pop() != c) return false; break;
                    default:
                        continue;
                }
            }
            return stack.Count == 0;
        }
    }
}
