using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Merge_k_Sorted_Lists
{
    //https://leetcode.com/problems/merge-k-sorted-lists/
    /*
     * Merge k sorted linked lists and return it as one sorted list. Analyze and describe its complexity.
     */

    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0) return null;
            int length = lists.Length;
            while (length > 1)
            {
                bool isOdd = length % 2 > 0;
                int i;
                for (i = 0; i < length / 2; i++)
                {
                    lists[i] = MergeTwoLists_Loops(lists[i], lists[length - i - 1]);
                }
                length /= 2;
                if (isOdd) length++;
            }
            return lists[0];
        }

        public ListNode MergeTwoLists_Loops(ListNode l1, ListNode l2)
        {
            ListNode tempNode = new ListNode(0);
            ListNode head = tempNode;
            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    tempNode.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    tempNode.next = l2;
                    l2 = l2.next;
                }
                tempNode = tempNode.next;
            }
            tempNode.next = l1 == null ? l2 : l1;
            return head.next;
        }

        public void Run()
        {
            ListNode l1 = null;
            ListNode l2 = new ListNode(1);
            ListNode[] lists = new ListNode[2];
            lists[0] = l1;
            lists[1] = l2;
            var result = MergeKLists(lists);
        }
    }
}
