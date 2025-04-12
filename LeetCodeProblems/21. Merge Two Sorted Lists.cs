using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem:
 * Merge two sorted linked lists and return it as a new sorted list. The new list should be made by splicing together the nodes of the first two lists.
 * 
 * URL: https://leetcode.com/problems/merge-two-sorted-lists/
 */
namespace LeetCodeProblems
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class _21
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // Create a dummy node to simplify edge cases.
            ListNode dummy = new ListNode(0);
            ListNode current = dummy;

            // Merge the two lists.
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

            // Attach the remaining part of list1 or list2.
            if (list1 != null)
            {
                current.next = list1;
            }
            else
            {
                current.next = list2;
            }

            // The merged list starts from the next node of the dummy.
            return dummy.next;
        }
        public static void Main(string[] args)
        {
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            ListNode list3 = new ListNode();
            list3 = new _21().MergeTwoLists(list1, list2);
            Console.WriteLine($"Merged List: {list3.val}");

        }
    }
}

