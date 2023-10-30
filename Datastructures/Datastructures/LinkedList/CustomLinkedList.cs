using System.Collections;

namespace Datastructures.LinkedList
{
    public class CustomLinkedList<T> : IEnumerable<T>
    {
        private bool IsCirculer = false;
        public LinkedListNode<T> Head { get; private set; }

        public void Add(T data)
        {
            if (!IsCirculer)
            {
                var newNode = new LinkedListNode<T>(data);
                if (Head == null)
                {
                    Head = newNode;
                }
                else
                {
                    var current = Head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }

                    current.Next = newNode;
                }
            }
            else
            {
                var newNode = new LinkedListNode<T>(data);
                if (Head == null)
                {
                    Head = newNode;
                    Head.Next = Head;
                }
                else
                {
                    var current = Head;
                    while (current != null)
                    {
                        if (current.Next == Head)
                        {
                            current.Next = newNode;
                            current.Next.Next = Head;
                            break;
                        }

                        current = current.Next;
                    }
                }
            }
        }

        public void Display()
        {
            var current = Head;
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
            var current = Head;
            LinkedListNode<T> next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            Head = previous;
        }

        public LinkedListNode<T> FindNode(T value)
        {
            var current = Head;

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
            Head = MergeSort(Head);
        }

        public void Traverse(Action<T> action)
        {
            var current = Head;
            while (current != null)
            {
                action(current.Data);
                current = current.Next;
            }
        }

        public int Count()
        {
            var counter = 0;
            if (Head == null)
            {
                return 0;
            }
            var current = Head;
            while (current != null)
            {
                counter++;
                current = current.Next;
            }

            return counter;
        }

        public void SetCircular(bool isCircular)
        {
            IsCirculer = isCircular;
            if (isCircular)
            {
                var current = Head;
                while (current != null)
                {
                    if (current.Next == null)
                    {
                        current.Next = Head;
                        break;
                    }

                    current = current.Next;
                }
            }
            else
            {
                var current = Head;
                while (current != null)
                {
                    if (current.Next == Head)
                    {
                        current.Next = null;
                        break;
                    }

                    current = current.Next;
                }
            }
        }

        public void RemoveDuplicates()
        {
            if (Head == null || IsCirculer)
            {
                return;
            }

            var current = Head;

            while (current != null)
            {
                var runner = current;
                while (runner.Next != null)
                {
                    if (EqualityComparer<T>.Default.Equals(current.Data, runner.Next.Data))
                    {
                        runner.Next = runner.Next.Next;
                    }
                    else
                    {
                        runner = runner.Next;
                    }
                }

                current = current.Next;
            }
        }

        public T FindNthToLast(int n)
        {
            if (n < 1 || Head == null || IsCirculer)
            {
                return default;
            }

            var firstPointer = Head;
            var secondPointer = Head;

            for (int i = 0; i < n; i++)
            {
                if (firstPointer.Next != null)
                {
                    firstPointer = firstPointer.Next;
                }
                else
                {
                    return default;
                }
            }

            while (firstPointer.Next != null)
            {
                firstPointer = firstPointer.Next;
                secondPointer = secondPointer.Next;
            }

            return secondPointer.Data;
        }

        public bool DeleteFromHead(int n)
        {
            if (n < 1 || Head == null)
            {
                return false;
            }

            if (n == 1)
            {
                Head = Head.Next;
                return true;
            }

            var current = Head;
            for (int i = 1; i < n - 1; i++)
            {
                if (current.Next != null)
                {
                    current = current.Next;
                }
                else
                {
                    return false;
                }
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
                return true;
            }

            return false;
        }

        public bool HasCycle()
        {
            if (Head == null)
            {
                return false;
            }

            var slow = Head;
            var fast = Head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                {
                    return true;
                }
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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
