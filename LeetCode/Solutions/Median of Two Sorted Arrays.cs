using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Median_of_Two_Sorted_Arrays
{
    public class Solution
    {
        //https://leetcode.com/problems/median-of-two-sorted-arrays
        /*
         * There are two sorted arrays nums1 and nums2 of size m and n respectively.
         * Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).
         *  
         * Example 1:
         * nums1 = [1, 3]
         * nums2 = [2]
         *
         * The median is 2.0
         * Example 2:
         * nums1 = [1, 2]
         * nums2 = [3, 4]
         * 
         * The median is (2 + 3)/2 = 2.5
         */
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums1.Length == 0)
            {
                nums1 = new int[] { };
            }
            if (nums2 == null || nums2.Length == 0)
            {
                nums2 = new int[] { };
            }
            if (nums1.Length > nums2.Length)
            {
                int[] temp = nums1;
                nums1 = nums2;
                nums2 = temp;
            }

            if (nums2.Length == 0) return 0;

            int iMin = 0;
            int iMax = nums1.Length;
            int halfLength = (nums1.Length + nums2.Length + 1) / 2;
            while (iMin <= iMax)
            {
                int i = (iMin + iMax) / 2;
                int j = halfLength - i;
                if (i < nums1.Length && nums2[j - 1] > nums1[i])
                {
                    iMin = i + 1;
                }
                else if (i > 0 && nums1[i - 1] > nums2[j])
                {
                    iMax = i - 1;
                }
                else
                {
                    int maxLeft, minRight;
                    if (i == 0)
                    {
                        maxLeft = nums2[j - 1];
                    }
                    else if (j == 0)
                    {
                        maxLeft = nums1[i - 1];
                    }
                    else
                    {
                        maxLeft = Math.Max(nums1[i - 1], nums2[j - 1]);
                    }
                    if ((nums1.Length + nums2.Length) % 2 == 1) return maxLeft;

                    if (i == nums1.Length)
                    {
                        minRight = nums2[j];
                    }
                    else if (j == nums2.Length)
                    {
                        minRight = nums1[i];
                    }
                    else
                    {
                        minRight = Math.Min(nums1[i], nums2[j]);
                    }
                    return (double)(maxLeft + minRight) / 2;
                }
            }
            return 0;
        }

        public void Run()
        {
            //int[] nums1 = new int[] { 1 };
            //int[] nums2 = new int[] { 2, 3, 4, 5 };
            //int[] nums1 = new int[] { 1, 2 };
            //int[] nums2 = new int[] { 3, 4 };
            int[] nums1 = new int[] { };
            int[] nums2 = new int[] { 1 };
            double result = FindMedianSortedArrays(nums1, nums2);
        }
    }
}
