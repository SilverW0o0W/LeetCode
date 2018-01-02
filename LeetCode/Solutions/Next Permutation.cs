using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Next_Permutation
{
    public class Solution
    {
        //https://leetcode.com/problems/next-permutation/
        /*
         * Implement next permutation, which rearranges numbers into the lexicographically next greater permutation of numbers.
         * If such arrangement is not possible, it must rearrange it as the lowest possible order (ie, sorted in ascending order).
         * The replacement must be in-place, do not allocate extra memory.
         * Here are some examples. Inputs are in the left-hand column and its corresponding outputs are in the right-hand column.
         * 3,2,1 → 1,2,3
         * 1,1,5 → 1,5,1
         * 1,2,3 → 1,3,2
         */
        public void NextPermutation(int[] nums)
        {
            int i = nums.Length - 2;
            while (i >= 0 && nums[i + 1] <= nums[i])
            {
                i--;
            }
            if (i >= 0)
            {
                int j = nums.Length - 1;
                while (j >= 0 && nums[j] <= nums[i])
                {
                    j--;
                }
                Swap(nums, i, j);
            }
            Reverse(nums, i + 1);
        }

        private void Reverse(int[] nums, int start)
        {
            int i = start, j = nums.Length - 1;
            while (i < j)
            {
                Swap(nums, i, j);
                i++;
                j--;
            }
        }

        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        public void Run()
        {
            int[] nums = new int[] { 1, 5, 8, 4, 7, 6, 5, 3, 1 };
            NextPermutation(nums);
        }
    }
}
