using ArrayOperations;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 1, 3, 5, 6, 10, 15 };
        ArrayOperation.MinAndMaxSwap(array);
        Console.WriteLine(string.Join(" ", array));
    }
}