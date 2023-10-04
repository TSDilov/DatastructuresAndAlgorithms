namespace Recursion.DataTypes
{
    public class LinkedList<T>
    {
        public LinkedListNode<T> Head { get; private set; }

        public void Add(T value)
        {
            var newNode = new LinkedListNode<T>(value);
            if (Head == null) { this.Head = newNode; }
            else 
            {
                var current = this.Head;
                while (current.Next != null) { current = current.Next; }
                current.Next = newNode;
            }
        }

        public void Reverse()
        {
            this.Head = ReverseRecursive(this.Head);
        }

        private LinkedListNode<T> ReverseRecursive(LinkedListNode<T> node)
        {
            if (node == null || node.Next == null) { return node; }
            var reversed = ReverseRecursive(node.Next);
            node.Next.Next = node;
            node.Next = null;

            return reversed;
        }
    }
}
