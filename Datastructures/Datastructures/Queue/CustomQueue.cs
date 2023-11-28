namespace Datastructures.Queue
{
    public class CustomQueue<T>
    {
        private LinkedList<T> list = new LinkedList<T>();

        public int Count { get => list.Count; }

        public void Enqueue(T item)
        {
            list.AddLast(item);
        }

        public T Dequeue() 
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            T item = list.First.Value;
            list.RemoveFirst();
            return item;
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }
    }
}
