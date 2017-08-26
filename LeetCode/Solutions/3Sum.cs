using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Three_Sum
{
    public class Solution
    {
        //https://leetcode.com/problems/3sum/
        /*
         * Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.
         * Note: The solution set must not contain duplicate triplets.
         * For example, given array S = [-1, 0, 1, 2, -1, -4],
         * A solution set is:
         * [
         *   [-1, 0, 1],
         *   [-1, -1, 2]
         * ]
         */
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            return null;
        }

        public void Run()
        {
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> result = ThreeSum(nums);
        }
    }
}
