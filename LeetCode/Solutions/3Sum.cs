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
            Array.Sort(nums);
            IList<IList<int>> res = new List<IList<int>>();
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
                {
                    int low = i + 1, high = nums.Length - 1, sum = 0 - nums[i];
                    while (low < high)
                    {
                        if (nums[low] + nums[high] == sum)
                        {
                            List<int> list = new List<int>();
                            list.Add(nums[i]);
                            list.Add(nums[low]);
                            list.Add(nums[high]);
                            res.Add(list);
                            while (low < high && nums[low] == nums[low + 1]) low++;
                            while (low < high && nums[high] == nums[high - 1]) high--;
                            low++; high--;
                        }
                        else if (nums[low] + nums[high] < sum) low++;
                        else high--;
                    }
                }
            }
            return res;
        }

        public void Run()
        {
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> result = ThreeSum(nums);
        }
    }
}
