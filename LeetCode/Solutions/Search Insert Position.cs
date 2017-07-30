using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Search_Insert_Position
{
    //https://leetcode.com/problems/search-insert-position
    /*
     * Given a sorted array and a target value, return the index if the target is found.If not, return the index where it would be if it were inserted in order.
     * You may assume no duplicates in the array.
     * Here are few examples.
     * [1, 3, 5, 6], 5 → 2
     * [1,3,5,6], 2 → 1
     * [1,3,5,6], 7 → 4
     * [1,3,5,6], 0 → 0
     */

    public class Solution
    {
        public int SearchInsert_Self(int[] nums, int target)
        {
            if (nums[0] >= target) return 0;
            if (nums[nums.Length - 1] < target) return nums.Length;
            return BinarySearch(nums, target, 0, nums.Length - 1);
        }

        private int BinarySearch(int[] nums, int target, int pre, int post)
        {
            if (pre >= post - 1)
            {
                return post;
            }
            int mid = (pre + post) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            else
            {
                if (nums[mid] > target)
                {
                    post = mid;
                }
                else
                {
                    pre = mid;
                }
                return BinarySearch(nums, target, pre, post);
            }
        }

        public int SearchInsert(int[] A, int target)
        {
            int low = 0, high = A.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (A[mid] == target) return mid;
                else if (A[mid] > target) high = mid - 1;
                else low = mid + 1;
            }
            return low;
        }

        public void Run()
        {
            int[] nums = new int[] { 1, 3, 5 };
            int result = SearchInsert_Self(nums, 2);
        }
    }
}
