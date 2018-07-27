using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Permutations_II
{
    public class Solution
    {
        //https://leetcode.com/problems/permutations-ii/
        /*
         * Given a collection of numbers that might contain duplicates, return all possible unique permutations.
         * Example:
         * Input: [1,1,2]
         * Output:
         * [
         *   [1,1,2],
         *   [1,2,1],
         *   [2,1,1]
         * ]
         */

        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();
            Array.Sort(nums);
            Backtrack(list, new List<int>(), nums, new bool[nums.Length]);
            return list;
        }


        private void Backtrack(IList<IList<int>> list, List<int> tempList, int[] nums, bool[] used)
        {
            if (tempList.Count == nums.Length)
            {
                list.Add(new List<int>(tempList));
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (used[i] || (i > 0 && nums[i] == nums[i - 1] && !used[i - 1])) continue;
                    tempList.Add(nums[i]);
                    used[i] = true;
                    Backtrack(list, tempList, nums, used);
                    used[i] = false;
                    tempList.RemoveAt(tempList.Count - 1);
                }
            }
        }

        public void Run()
        {
            int[] nums = new int[] { 1, 1, 2 };
            var result = PermuteUnique(nums);
        }
    }
}
