using System.Xml.Linq;

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
    }
}
