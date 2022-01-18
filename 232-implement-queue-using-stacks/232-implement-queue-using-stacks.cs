public class MyQueue
    {
        private int _count;
        class QueueItem
        {
            public int Value;
            public QueueItem Next;
        }

        QueueItem head;

        public MyQueue()
        {
            head = null;
        }

        public void Push(int x)
        {
            _count++;
            QueueItem newItem = new QueueItem();
            newItem.Value = x;
            if (head == null)
            {
                head = newItem;
            }
            else
            {
                QueueItem p = head;
                while (p.Next != null)
                {
                    p = p.Next;
                }
                p.Next = newItem;
            }
        }

        public int Pop()
        {
            _count--;
            int r = head.Value;
            QueueItem p = head;
            head = head.Next;
            return r;
        }

        public int Peek()
        {
            return head?.Value == null ? -1 : head.Value;
        }

        public bool Empty()
        {
            return _count == 0 ? true : false;
        }
    }

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */