using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ThreeSum_Closest
{
    public class Solution
    {
        //https://leetcode.com/problems/3sum-closest/
        /*
         * Given an array S of n integers, find three integers in S such that the sum is closest to a given number, target.Return the sum of the three integers.You may assume that each input would have exactly one solution.
         * For example, given array S = { -1 2 1 - 4 }, and target = 1.
         * The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
        */
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int result = nums[0] + nums[1] + nums[nums.Length - 1];
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int start = i + 1, end = nums.Length - 1;
                while (start < end)
                {
                    int sum = nums[i] + nums[start] + nums[end];
                    if (sum == target)
                    {
                        return target;
                    }
                    else if (sum > target)
                    {
                        end--;
                    }
                    else
                    {
                        start++;
                    }
                    if (Math.Abs(sum - target) < Math.Abs(result - target))
                    {
                        result = sum;
                    }
                }
            }
            return result;
        }

        public void Run()
        {
            //int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            int[] nums = new int[] { 1, 2, 4, 8, 16, 32, 64, 128 };
            int target = 82;
            int result = ThreeSumClosest(nums, target);
        }
    }
}
