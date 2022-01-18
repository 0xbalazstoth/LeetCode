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
    public ListNode MiddleNode(ListNode head) {
        int i = 0;
        ListNode p = head;
        while (p != null)
        {
            p = p.next;
            i++;
        }

        double middle = (i % 2 == 0) ? Math.Ceiling((double)i / (double)2) + 1 : Math.Ceiling((double)i / (double)2);
        int middleIndex = (int)middle - 1;

        int j = 0;
        ListNode k = head;
        while (j < middleIndex && j < i)
        {
            k = k.next;
            j++;
        }
        return k;
    }
}