using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ThreeSum_Closest
{
    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            long diff = target > 0 ? (long)target - int.MinValue : (long)-target + int.MaxValue;
            int result = int.MinValue;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
                {
                    int low = i + 1;
                    int high = nums.Length - 1;
                    while (low < high)
                    {
                        int sum = nums[i] + nums[low] + nums[high];
                        if (sum == target)
                        {
                            return target;
                        }
                        long tempDiff = target > 0 ? (long)target - sum : (long)-target - sum;
                        if (Math.Abs(tempDiff) > diff)
                        {
                            break;
                        }
                        diff = target - sum;
                        result = sum;
                        if (target >= 0)
                        {
                            if (target - sum > 0) low++;
                            else high--;
                        }
                        else
                        {
                            if (target + sum < 0) low++;
                            else high--;
                        }
                    }
                }
            }
            return result;
        }

        public void Run()
        {
            //int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            int[] nums = new int[] { 1, 2, 4, 8, 16, 32, 64, 128 };
            int target = 82;
            int result = ThreeSumClosest(nums, target);
        }
    }
}
