using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Find_First_and_Last_Position_of_Element_in_Sorted_Array
{
    public class Solution
    {
        /*
         * Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.
         * Your algorithm's runtime complexity must be in the order of O(log n).
         * If the target is not found in the array, return [-1, -1].
         * Example 1:
         * Input: nums = [5,7,7,8,8,10], target = 8
         * Output: [3,4]
         * Example 2:
         * Input: nums = [5,7,7,8,8,10], target = 6
         * Output: [-1,-1]
         */

        public int[] SearchRange(int[] nums, int target)
        {
            return BinarySearch(nums, 0, nums.Length - 1, target);
        }

        private int[] BinarySearch(int[] nums, int begin, int end, int target)
        {
            if (nums.Length < 1 || begin >= end && target != nums[begin])
                return new int[] { -1, -1 };
            int mid = (begin + end) / 2;
            if (target == nums[mid])
            {
                int before = mid, after = mid;
                while (before >= 0 && target == nums[before])
                    before--;
                while (after <= end && target == nums[after])
                    after++;
                return new int[] { before + 1, after - 1 };
            }
            // target > nums[mid]
            else if (target > nums[mid])
                return BinarySearch(nums, mid + 1, end, target);
            // target < nums[mid]
            else
                return BinarySearch(nums, begin, mid - 1, target);
        }


        public void Run()
        {
            int[] nums = new int[] { 5, 7, 7, 8, 8, 10 };
            int[] result = SearchRange(nums, 8);
        }
    }
}
