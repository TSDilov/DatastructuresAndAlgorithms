namespace Datastructures.Queue
{
    public class CustomPriorityQueue<T>
    {
        private List<T> heap = new List<T>();
        private readonly Comparison<T> comparison;

        public CustomPriorityQueue(Comparison<T> comparison) 
        {
            this.comparison = comparison;
        }

        public int Count { get => heap.Count; }

        public void Enqueue(T item)
        {
            heap.Add(item);
            var i = this.heap.Count - 1;
            while (i > 0) 
            {
                int j = (i - 1) / 2;
                if (this.comparison(this.heap[i], this.heap[j]) >= 0)
                {
                    break;
                }
                Swap(i, j);
                i = j;
            }
        }

        public T Dequeue()
        { 
            var count = this.heap.Count - 1;
            T ret = this.heap[0];
            this.heap[0] = this.heap[count];
            this.heap.RemoveAt(count);

            count--;
            var i = 0;
            while (true) 
            {
                var j = i * 2 + 1;
                if (j > count)
                {
                    break;
                }

                var k = j + 1;
                if (k <= count && this.comparison(this.heap[k], this.heap[j]) < 0)
                {
                    j = k;
                }

                if (this.comparison(this.heap[j], this.heap[i]) >= 0)
                {
                    break;
                }

                Swap(i, j);
                i = j;
            }

            return ret;
        }

        private void Swap(int i, int j)
        {
            T tmp = heap[i];
            heap[i] = heap[j];
            heap[j] = tmp;
        }
    }
}
