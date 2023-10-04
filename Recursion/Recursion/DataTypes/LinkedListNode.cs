namespace Recursion.DataTypes
{
    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            this.Value = value;            
        }
        public T Value { get; }
        public LinkedListNode<T> Next { get; set; }

    }
}
