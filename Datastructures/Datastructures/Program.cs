using Datastructures.Graph;
using Datastructures.Queue;

internal class Program
{
    private static void Main(string[] args)
    {
       var queue = new CustomQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        while (!queue.IsEmpty())
        {
            Console.WriteLine(queue.Dequeue());
        }

        var priorityQueue = new CustomPriorityQueue<int>((a, b) => a.CompareTo(b));
        priorityQueue.Enqueue(3);
        priorityQueue.Enqueue(1);
        priorityQueue.Enqueue(2);

        while (priorityQueue.Count > 0)
        {
            Console.WriteLine(priorityQueue.Dequeue());
        }
    }
}