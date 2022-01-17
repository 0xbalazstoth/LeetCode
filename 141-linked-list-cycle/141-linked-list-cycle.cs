/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
using System;
using System.Collections.Generic;

public class Solution {
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> hs = new HashSet<ListNode>();
        while(head != null)
        {
            if(hs.Contains(head))
            {
                return true;
            }
            hs.Add(head);
            head = head.next;
        }
        return false;
    }
}