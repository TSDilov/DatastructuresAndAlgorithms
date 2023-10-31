using System.Collections;

namespace Datastructures.Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> items = new List<T> ();

        public int Count 
        {
            get { return items.Count; }
        }

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            T poppedItem = items[this.Count - 1];
            items.RemoveAt(this.Count - 1);
            return poppedItem;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            return items[this.Count - 1];
        }

        public bool IsEmpty()
        { 
            return this.Count == 0;
        }

        public void Clear()
        {
            items.Clear();
        }

        public CustomStack<T> Reverse()
        {
            if (this.Count <= 1)
            {
                throw new InvalidOperationException("The stack is IsEmpty or HashCode only one element");
            }
            var stack = this;
            var newStack = new CustomStack<T>();
            while (!IsEmpty()) 
            {
                newStack.Push(Pop());
            }

            return newStack;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = this.Count - 1;  i >= 0; i--)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
