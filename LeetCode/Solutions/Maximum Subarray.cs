using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Maximum_Subarray
{
    public class Solution
    {
        //https://leetcode.com/problems/maximum-subarray/
        /*
         * Given an integer array nums, find the contiguous subarray(containing at least one number) which has the largest sum and return its sum.
         * Example:
         * Input: [-2,1,-3,4,-1,2,1,-5,4],
         * Output: 6
         * Explanation: [4,-1,2,1] has the largest sum = 6.
         * Follow up:
         * If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.
         */
        public int MaxSubArray(int[] nums)
        {
            int n = nums.Length;
            //dp[i] means the maximum subarray ending with nums[i];
            int[] dp = new int[n];
            dp[0] = nums[0];
            int max = dp[0];

            for (int i = 1; i < n; i++)
            {
                dp[i] = nums[i] + (dp[i - 1] > 0 ? dp[i - 1] : 0);
                max = Math.Max(max, dp[i]);
            }

            return max;
        }

        public void Run()
        {
            int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int result = MaxSubArray(nums);
        }
    }
}
