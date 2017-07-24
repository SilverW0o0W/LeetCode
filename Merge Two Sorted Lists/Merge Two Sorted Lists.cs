using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Two_Sorted_Lists
{
    //https://leetcode.com/problems/merge-two-sorted-lists
    /*
     * Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.
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
        //For loops
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
            ListNode l1 = new ListNode(0);
            l1.next = new ListNode(1);
            ListNode l2 = new ListNode(2);
            l2.next = new ListNode(3);
            ListNode answer = MergeTwoLists_Loops(l1, l2);
        }
    }
}
