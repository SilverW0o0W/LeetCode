using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Subsets
{
    public class Solution
    {
        //https://leetcode.com/problems/subsets/
        /*
         * Given a set of distinct integers, nums, return all possible subsets (the power set).
         * Note: The solution set must not contain duplicate subsets.
         * Example:
         * Input: nums = [1,2,3]
         * Output:
         * [
         *   [3],
         *   [1],
         *   [2],
         *   [1,2,3],
         *   [1,3],
         *   [2,3],
         *   [1,2],
         *   []
         * ]
         */
        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();
            Backtrack(list, new List<int>(), nums, 0);
            return list;
        }

        public void Backtrack(IList<IList<int>> list, List<int> tempList, int[] nums, int start)
        {
            list.Add(new List<int>(tempList));
            for (int i = start; i < nums.Length; i++)
            {
                tempList.Add(nums[i]);
                Backtrack(list, tempList, nums, i + 1);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }

        public IList<IList<int>> Subsets_1st(int[] nums)
        {
            List<IList<int>> ans = new List<IList<int>>();
            ans.Add(new List<int>());

            foreach (var n in nums)
            {
                int length = ans.Count();
                for (int i = 0; i < length; i++)
                {
                    var curr = new List<int>(ans.ElementAt(i));
                    curr.Add(n);
                    ans.Add(curr);
                }
            }

            return ans;
        }


        public void Run()
        {
            int[] nums = new int[] { 1, 2, 3 };
            IList<IList<int>> result = Subsets(nums);
        }
    }
}
