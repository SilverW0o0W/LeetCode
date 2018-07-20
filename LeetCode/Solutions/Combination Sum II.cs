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
        private int[] candidates;
        private IList<IList<int>> lists;
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            lists = new List<IList<int>>();
            Array.Sort(candidates);
            this.candidates = candidates;
            List<int> list = new List<int>();
            GetSum(target, list, -1);
            return lists;
        }

        private void GetSum(int target, IList<int> list, int lastIndex)
        {
            for (int i = lastIndex + 1; i < candidates.Length; i++)
            {
                //if (lastIndex != -1 && candidates[i] == candidates[i - 1]) continue;
                int remind = target - candidates[i];
                if (remind == 0)
                {
                    IList<int> newList = new List<int>(list);
                    newList.Add(candidates[i]);
                    lists.Add(newList);
                    break;
                }
                else if (remind > 0)
                {
                    IList<int> newList = new List<int>(list);
                    newList.Add(candidates[i]);
                    GetSum(remind, newList, i);
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
