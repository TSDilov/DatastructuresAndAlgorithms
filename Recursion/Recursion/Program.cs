using Recursion;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 5, 2, 9, 1, 5, 6, 3 };

        OperationWithRecursion.QuickSortAlgorithm(array, 0, array.Length - 4);
        Console.WriteLine(string.Join(" ", array));
    }
}