using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Datastructures.Datastructures
{
    public class LinkedListNode<T>
    {
        public LinkedListNode(T data)
        {
            this.Data = data;
            this.Next = null;
        }

        public T Data { get; set; }

        public LinkedListNode<T> Next { get; set; } 
    }
}
