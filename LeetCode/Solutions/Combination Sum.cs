using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Combination_Sum
{
    public class Solution
    {
        //https://leetcode.com/problems/combination-sum/
        /*
         * Given a set of candidate numbers (C) (without duplicates) and a target number (T), find all unique combinations in C where the candidate numbers sums to T.
         * The same repeated number may be chosen from C unlimited number of times.
         * Note:
         * All numbers (including target) will be positive integers.
         * The solution set must not contain duplicate combinations.
         * For example, given candidate set [2, 3, 6, 7] and target 7, 
         * A solution set is: 
         * [
         *   [7],
         *   [2, 2, 3]
         * ]
         */
        private int[] candidates;
        private IList<IList<int>> lists;
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            lists = new List<IList<int>>();
            this.candidates = candidates;
            List<int> list = new List<int>();
            GetSum(target, list, -1);
            return lists;
        }

        private void GetSum(int target, IList<int> list, int lastNumber)
        {
            foreach (int candidate in candidates)
            {
                if (lastNumber > candidate)
                {
                    continue;
                }
                int remind = target - candidate;
                if (remind == 0)
                {
                    IList<int> newList = new List<int>(list);
                    newList.Add(candidate);
                    lists.Add(newList);
                }
                else if (remind > 0)
                {
                    IList<int> newList = new List<int>(list);
                    newList.Add(candidate);
                    GetSum(remind, newList, candidate);
                }
            }
        }

        public void Run()
        {
            int[] candidates = new int[] { 2, 3, 6, 7 };
            int target = 7;
            IList<IList<int>> result = CombinationSum(candidates, target);
        }
    }
}
