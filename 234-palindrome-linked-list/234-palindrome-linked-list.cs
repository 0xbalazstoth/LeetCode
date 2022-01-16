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
    public bool IsPalindrome(ListNode head) {
        ListNode p = head;
        bool isPalindrome = true;
        //_Stack<int> stack = new _Stack<int>();
        Stack<int> stack = new Stack<int>();
        
        while(p != null)
        {
            stack.Push(p.val);
            p = p.next;
        }
        
        while(head != null)
        {
            int i = stack.Pop();
            if(head.val == i)
            {
                isPalindrome = true;
            }
            else
            {
                isPalindrome = false;
                break;
            }
            head = head.next;
        }
        return isPalindrome;
    }
}

public class _Stack<T> : IEnumerable<T>
{
    private T[] _stackArray;
    
    public _Stack()
    {
        _stackArray = new T[0];
    }
    
    public int Count
    {
        get
        {
            return _stackArray.Length;
        }
    }
    
    public void Clear()
    {
        T[] emptyArray = new T[0];
        _stackArray = emptyArray;
    }
    
    public T Pop()
    {
        int end = _stackArray.Length - 1;
        T r = _stackArray[end];
        T[] newStackArray = new T[end];
        for (int i = end - 1; i >= 0; i--)
        {
            newStackArray[i] = _stackArray[i];
        }
        _stackArray = newStackArray;
        return r;
    }
    
    public void Push(T content)
    {
        T[] newStackArray = new T[_stackArray.Length + 1];
        for (int i = _stackArray.Length - 1; i >= 0; i--)
        {
            newStackArray[i] = _stackArray[i];
        }
        newStackArray[newStackArray.Length - 1] = content;
        _stackArray = newStackArray;
    }
    
    public T Peak()
    {
        int end = _stackArray.Length - 1;
        return _stackArray[end];
    }
    
    public IEnumerator<T> GetEnumerator()
    {
        for(int i = _stackArray.Length - 1; i >= 0; i--)
        {
            yield return _stackArray[i];
        }
    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}