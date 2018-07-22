using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Permutations
{
    public class Solution
    {
        //https://leetcode.com/problems/permutations/
        /*
         * Given a collection of distinct integers, return all possible permutations.
         * Example:
         * Input: [1,2,3]
         * Output:
         * [
         *   [1,2,3],
         *   [1,3,2],
         *   [2,1,3],
         *   [2,3,1],
         *   [3,1,2],
         *   [3,2,1]
         * ] 
         */
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();
            Backtrack(list, new List<int>(), nums);
            return list;
        }

        private void Backtrack(IList<IList<int>> list, List<int> tempList, int[] nums)
        {
            if (tempList.Count == nums.Length)
            {
                list.Add(new List<int>(tempList));
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (tempList.Contains(nums[i])) continue;
                    tempList.Add(nums[i]);
                    Backtrack(list, tempList, nums);
                    tempList.RemoveAt(tempList.Count - 1);
                }
            }
        }

        public void Run()
        {
            int[] nums = new int[] { 1, 2, 3 };
            IList<IList<int>> result = Permute(nums);
        }
    }
}
