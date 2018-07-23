using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Combination_Sum_II
{
    public class Solution
    {
        //https://leetcode.com/problems/combination-sum-ii/
        /*
         * Given a collection of candidate numbers (C) and a target number (T), find all unique combinations in C where the candidate numbers sums to T.
         * Each number in C may only be used once in the combination.
         * Note:
         * All numbers (including target) will be positive integers.
         * The solution set must not contain duplicate combinations.
         * For example, given candidate set [10, 1, 2, 7, 6, 1, 5] and target 8, 
         * A solution set is: 
         * [
         *   [1, 7],
         *   [1, 2, 5],
         *   [2, 6],
         *   [1, 1, 6]
         * ]
         */


        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            IList<IList<int>> list = new List<IList<int>>();
            Array.Sort(candidates);
            BackTrack(list, new List<int>(), candidates, target, 0);
            return list;
        }


        private void BackTrack(IList<IList<int>> list, List<int> tempList, int[] nums, int remain, int start)
        {
            if (remain < 0) return;
            else if (remain == 0) list.Add(new List<int>(tempList));
            else
            {
                for (int i = start; i < nums.Length; i++)
                {
                    if (i > start && nums[i] == nums[i - 1]) continue; // skip duplicates
                    tempList.Add(nums[i]);
                    BackTrack(list, tempList, nums, remain - nums[i], i + 1);
                    tempList.RemoveAt(tempList.Count - 1);
                }
            }
        }

        public void Run()
        {
            int[] candidates = new int[] { 3, 1, 3, 5, 1, 1 };
            int target = 8;
            IList<IList<int>> result = CombinationSum2(candidates, target);
        }
    }
}
