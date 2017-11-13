using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Swap_Nodes_in_Pairs
{
    //https://leetcode.com/problems/swap-nodes-in-pairs/
    /*
     * Given a linked list, swap every two adjacent nodes and return its head.
     * For example,
     * Given 1->2->3->4, you should return the list as 2->1->4->3.
     * Your algorithm should use only constant space.You may not modify the values in the list, only nodes itself can be changed.
     */

    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class Solution
    {
        public ListNode SwapPairs_Self(ListNode head)
        {
            if (head == null) return null;
            ListNode realHead = head.next ?? head;
            ListNode tempHead = head;
            ListNode tempPre = new ListNode(0);
            while (tempHead != null && tempHead.next != null)
            {
                ListNode tempNext = tempHead.next;
                tempPre.next = tempNext;
                tempHead.next = tempNext.next;
                tempNext.next = tempHead;
                tempPre = tempHead;
                tempHead = tempHead.next;
            }
            return realHead;
        }


        public ListNode SwapPairs(ListNode head)
        {
            if ((head == null) || (head.next == null))
                return head;
            ListNode n = head.next;
            head.next = SwapPairs(head.next.next);
            n.next = head;
            return n;
        }

        public void Run()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            var result = SwapPairs(head);
        }
    }
}
