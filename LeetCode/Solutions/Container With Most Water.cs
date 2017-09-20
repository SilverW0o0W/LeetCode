using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Container_With_Most_Water
{
    public class Solution
    {
        //https://leetcode.com/problems/container-with-most-water/

        /*
         * Given n non-negative integers a1, a2, ..., an, where each represents a point at coordinate (i, ai). n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). Find two lines, which together with x-axis forms a container, such that the container contains the most water.
         * Note: You may not slant the container and n is at least 2.
         */

        public int MaxArea(int[] height)
        {
            int left = 0, right = height.Length - 1;
            int maxArea = Math.Min(height[left], height[right]) * (right - left);

            while (left < right)
            {
                int x, y;
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
                x = right - left;
                y = Math.Min(height[left], height[right]);
                int area = x * y;
                maxArea = maxArea > area ? maxArea : area;
            }
            return maxArea;
        }

        public void Run()
        {
            int[] height = { 1, 1 };
            int result = MaxArea(height);
        }
    }
}
