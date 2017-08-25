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
            IList<IList<int>> result = new List<IList<int>>();
            Hashtable hashtable = new Hashtable();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    KeyValuePair<int, int> pair = new KeyValuePair<int, int>(nums[i], nums[j]);
                    AddToTable(hashtable, nums[i] + nums[j], pair);
                }
            }

            nums = nums.Distinct().ToArray();
            foreach (int num in nums)
            {
                int negativeNum = -num;
                if (hashtable.Contains(negativeNum))
                {
                    foreach (KeyValuePair<int, int> pair in hashtable[negativeNum] as Hashtable)
                    {
                        IList<int> list = new List<int>();
                        list.Add(pair.Key);
                        list.Add(pair.Value);
                        list.Add(num);
                        result.Add(list);
                    }
                }
            }
            return result;
        }

        private void AddToTable(Hashtable hashtable, int key, KeyValuePair<int, int> pair)
        {
            Hashtable hashtableTemp;
            if (hashtable.ContainsKey(key))
            {
                hashtableTemp = hashtable[key] as Hashtable;
            }
            else
            {
                hashtableTemp = new Hashtable();
                hashtable[key] = hashtableTemp;
            }
            if (hashtableTemp.ContainsKey(pair.Key))
            {
                hashtableTemp.Add(pair.Key, pair.Value);
            }

        }

        public void Run()
        {
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> result = ThreeSum(nums);
        }
    }
}
