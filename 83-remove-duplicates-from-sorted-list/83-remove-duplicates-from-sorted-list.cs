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
    public ListNode DeleteDuplicates(ListNode head) {
        SortedSet<int> h = new SortedSet<int>();
        ListNode p = head;
        while (p != null) {
            h.Add(p.val);
            p = p.next;
        }
        
        ListNode newHead = new ListNode();
        
        foreach (var i in h) {
            Insert(newHead, i);
        }
        
        ListNode answer = RemoveFirst(newHead);
        
        return answer;
    }
    
    public void Insert(ListNode head, int val) {
        ListNode newItem = new ListNode();
        newItem.val = val;
        if (head == null) {
            head = newItem;
        } else {
            ListNode p = head;
            while (p.next != null) {
                p = p.next;
            }
            p.next = newItem;
        }
    }
    
    public ListNode RemoveFirst(ListNode p) {
        if (p == null) {
            return null;
        }
        
        ListNode temp = p;
        p = p.next;
        return p;
    }
}