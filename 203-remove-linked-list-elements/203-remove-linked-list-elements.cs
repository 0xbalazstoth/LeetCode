/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode p = head;
        ListNode e = null;
        while(p != null && p.val == val)
        {
            head = p.next;
            p = head;
        }
        while(p != null)
        {
            while(p != null && p.val != val)
            {
                e = p;
                p = p.next;
            }
            
            if(p == null)
            {
                return head;
            }
            
            e.next = p.next;
            p = e.next;
        }
        return head;
    }
}