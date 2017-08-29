using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LeetCode.Remove_Nth_Node_From_End_of_List
{

    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        //https://leetcode.com/problems/remove-nth-node-from-end-of-list/
        /* Given a linked list, remove the nth node from the end of list and return its head.
         * For example,
         *     Given linked list: 1->2->3->4->5, and n = 2.
         *     After removing the second node from the end, the linked list becomes 1->2->3->5.
         * Note:
         *   Given n will always be valid.
         *   Try to do this in one pass.
         */

        public ListNode RemoveNthFromEnd_self(ListNode head, int n)
        {
            ListNode node = head;
            int count = 0, moveTime;
            while (node != null)
            {
                count++;
                node = node.next;
            }
            moveTime = count - n - 1;
            if (moveTime == -1) return head.next;
            if (moveTime < -1) return null;
            node = head;
            for (int i = 0; i < moveTime; i++) node = node.next;
            ListNode delNode = node.next;
            node.next = delNode.next;
            return head;
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode start = new ListNode(0);
            ListNode slow = start, fast = start;
            slow.next = head;

            //Move fast in front so that the gap between slow and fast becomes n
            for (int i = 1; i <= n + 1; i++)
            {
                fast = fast.next;
            }
            //Move fast to the end, maintaining the gap
            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next;
            }
            //Skip the desired node
            slow.next = slow.next.next;
            return start.next;
        }

        public void Run()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            ListNode result = RemoveNthFromEnd(head, 5);
        }
    }
}
