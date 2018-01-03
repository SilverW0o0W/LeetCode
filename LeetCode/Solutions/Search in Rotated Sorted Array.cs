using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Search_in_Rotated_Sorted_Array
{
    public class Solution
    {
        //https://leetcode.com/problems/search-in-rotated-sorted-array/
        /*
         * Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
         * (i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).
         * You are given a target value to search. If found in the array return its index, otherwise return -1.
         * You may assume no duplicate exists in the array.
         */

        public int Search(int[] nums, int target)
        {
            if (nums.Length == 0) return -1;
            return BinarySearch(nums, 0, nums.Length - 1, target);
        }

        public int BinarySearch(int[] nums, int left, int right, int target)
        {
            if (left > right)
            {
                return -1;
            }
            int mid = (left + right + 1) / 2;
            if (target == nums[mid]) return mid;
            if (nums[mid] > nums[right])
            {
                if (target > nums[mid] || target <= nums[right]) left = mid + 1;
                else right = mid - 1;
            }
            else
            {
                if (target < nums[mid] || target > nums[right]) right = mid - 1;
                else left = mid + 1;
            }
            return BinarySearch(nums, left, right, target);
        }

        public void Run()
        {
            //int[] nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            int[] nums = new int[] { 1, 3, 5 };
            int result = Search(nums, 5);
        }
    }
}
