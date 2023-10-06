namespace Datastructures.Datastructures
{
    public class CustomLinkedList<T>
    {
        public LinkedListNode<T> Head { get; private set; }

        public void Add(T data)
        {
            var newNode = new LinkedListNode<T>(data);
            if (this.Head == null)
            {
                this.Head = newNode;
            }
            else 
            {
                var current = this.Head;
                while (current.Next != null) 
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }

        public void Display()
        {
            var current = this.Head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public void Reverse()
        {
            LinkedListNode<T> previous = null;
            var current = this.Head;
            LinkedListNode<T> next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            this.Head = previous;
        }

        public LinkedListNode<T> FindNode(T value)
        {
            var current = this.Head;

            while (current != null) 
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, value))
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }

        public void Sort()
        {
            this.Head = MergeSort(this.Head);
        }

        private LinkedListNode<T> MergeSort(LinkedListNode<T> head)
        {
            if (head == null || head.Next == null)
            {
                return head;
            }

            var middle = GetMiddle(head);
            var nextToMiddle = middle.Next;
            middle.Next = null;

            var left = MergeSort(head);
            var right = MergeSort(nextToMiddle);

            return Merge(left, right);
        }

        private LinkedListNode<T> Merge(LinkedListNode<T> left, LinkedListNode<T> right)
        {
            LinkedListNode<T> result = null;
            if (left == null) 
            {
                return right;
            }
            else if (right == null) 
            {
                return left;
            }

            if (Comparer<T>.Default.Compare(left.Data, right.Data) <= 0)
            {
                result = left;
                result.Next = Merge(left.Next, right);
            }
            else 
            {
                result = right;
                result.Next = Merge(left, right.Next);
            }

            return result;
        }

        private LinkedListNode<T> GetMiddle(LinkedListNode<T> head)
        {
            if (head == null)
            {
                return null;
            }

            var slow = head;
            var fast = head;
            while (fast.Next != null && fast.Next.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow;
        }
    }
}
