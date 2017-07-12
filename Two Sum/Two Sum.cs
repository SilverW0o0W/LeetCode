using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    //https://leetcode.com/problems/two-sum
    //The question might change. Past index might be +1
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            Hashtable table = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                if (table.ContainsKey(target - nums[i]))
                {
                    result[1] = i;
                    result[0] = (int)(table[target - nums[i]]);
                    return result;
                }
                if (!table.ContainsKey(nums[i]))
                {
                    table.Add(nums[i], i);
                }
            }
            return result;
        }
    }
}
