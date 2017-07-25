using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates_from_Sorted_Array
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-array
    /*
     * Given a sorted array, remove the duplicates in place such that each element appear only once and return the new length.
     * Do not allocate extra space for another array, you must do this in place with constant memory.
     * For example,
     * Given input array nums = [1,1,2],
     * Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively. It doesn't matter what you leave beyond the new length. 
     */

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int pre = nums[0];
            int count = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (pre != nums[i])
                {
                    pre = nums[i];
                    nums[count++] = nums[i];
                }
            }
            //Array.Resize(ref nums, count);
            return count;
        }

        public void Run()
        {
            int[] input = new int[] { 1, 1, 2 };
            int answer = RemoveDuplicates(input);
        }
    }
}
