using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    //https://leetcode.com/problems/palindrome-number
    /*
     * Determine whether an integer is a palindrome. Do this without extra space.
     */
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0)) return false;
            int rev = 0;
            while (x > rev)
            {
                rev = rev * 10 + x % 10;
                x /= 10;
            }
            //rev == x for even || x == rev / 10 for odd
            return rev == x || x == rev / 10;
        }
    }
}
