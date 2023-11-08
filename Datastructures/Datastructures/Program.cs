using Datastructures.BinarySearchTree;
using Datastructures.SortingAlgorithms;
using Datastructures.Stack;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 64, 25, 12, 22, 11 };
        var list = CustomSort.SelectionSortAlgorithm(arr);
        Console.WriteLine(string.Join(", ", list));
    }
}