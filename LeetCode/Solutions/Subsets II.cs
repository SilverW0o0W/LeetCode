using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Subsets_II
{
    public class Solution
    {
        //https://leetcode.com/problems/subsets-ii/
        /*
         * Given a collection of integers that might contain duplicates, nums, return all possible subsets (the power set).
         * Note: The solution set must not contain duplicate subsets.
         * Example:
         * Input: [1,2,2]
         * Output:
         * [
         *   [2],
         *   [1],
         *   [1,2,2],
         *   [2,2],
         *   [1,2],
         *   []
         * ]
         */

        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();
            Array.Sort(nums);
            Backtrack(list, new List<int>(), nums, 0);
            return list;
        }

        public void Backtrack(IList<IList<int>> list, List<int> tempList, int[] nums, int start)
        {

            list.Add(new List<int>(tempList));
            for (int i = start; i < nums.Length; i++)
            {
                if (i > start && nums[i] == nums[i - 1]) continue;
                tempList.Add(nums[i]);
                Backtrack(list, tempList, nums, i + 1);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }

        public void Run()
        {
            int[] nums = new int[] { 1, 2, 2 };
            IList<IList<int>> result = SubsetsWithDup(nums);
        }
    }
}
