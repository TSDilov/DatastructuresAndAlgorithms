using Datastructures.BinarySearchTree;
using Datastructures.SortingAlgorithms;
using Datastructures.Stack;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 64, 25, 12, 22, 11, 22 };

        var stack = new Stack<int>();
        stack.Push(arr[0]);
        stack.Push(arr[1]);
        stack.Push(arr[2]);
        stack.Push(arr[3]);
        stack.Push(arr[4]);
        stack.Push(arr[5]);
        var list = CustomSort.HeapSortAlgorithm(arr);
        Console.WriteLine(string.Join(", ", list));
    }
}