public class Node
{
    public int val { get; set; }
    public Node next { get; set; }
}

public class MyLinkedList
{
    private Node head;
    public MyLinkedList()
    {
        head = null;
    }

    public void AddAtHead(int val)
    {
        Node newItem = new Node();
        newItem.val = val;
        newItem.next = head;
        head = newItem;
    }

    public int Get(int index)
    {
        Node p = head;
        int i = 0;
        while (p != null && i < index)
        {
            p = p.next;
            i++;
        }
        bool found = (p != null);
        int foundItem = -1;
        if (found)
        {
            foundItem = p.val;
        }
        return foundItem;
    }

    public void AddAtTail(int val)
    {
        Node newItem = new Node();
        newItem.val = val;
        if (head == null)
        {
            head = newItem;
        }
        else
        {
            Node p = head;
            while (p.next != null)
            {
                p = p.next;
            }
            p.next = newItem;
        }
    }

    public int Count()
    {
        Node p = head;
        int count = 0;
        while (p != null)
        {
            p = p.next;
            count++;
        }
        return count;
    }

    public void AddAtIndex(int index, int val)
    {
        int count = Count();
        if (index > count)
        {
            return;
        }
        else if (index == count)
        {
            AddAtTail(val);
        }
        else
        {
            Node newItem = new Node();
            newItem.val = val;
            if (head == null || index == 0)
            {
                newItem.next = head;
                head = newItem;
            }
            else
            {
                Node p = head;
                int i = 1;
                while (p != null && i < index)
                {
                    p = p.next;
                    i++;
                }
                newItem.next = p.next;
                p.next = newItem;
            }
        }
    }

    public void DeleteAtIndex(int index)
    {
        if (head == null)
        {
            return;
        }

        Node p = head;
        if (index == 0)
        {
            head = p.next;
            return;
        }

        for (int i = 0; p != null && i < index - 1; i++)
        {
            p = p.next;
        }

        if (p == null || p.next == null)
        {
            return;
        }

        Node e = p.next.next;
        p.next = e;
    }
}