using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Insert_Position
{
    //https://leetcode.com/problems/search-insert-position
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums[0] >= target) return 0;
            if (nums[nums.Length - 1] <= target) return nums.Length - 1;
            return BinarySearch(nums, target, 0, nums.Length - 1);
        }

        private int BinarySearch(int[] nums, int target, int pre, int post)
        {
            if (pre == post)
            {
                return pre;
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
                BinarySearch(nums, target, pre, post);
                return mid;
            }
        }

        public void Run()
        {
            int[] nums = new int[] { 1, 3, 5 };
            int result = SearchInsert(nums, 2);
        }
    }
}
