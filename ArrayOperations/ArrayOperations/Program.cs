using ArrayOperations;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 3, 2, 3, 1, 5, 4 };
        var sortedArray = ArrayOperation.Descending(array);
        Console.WriteLine(string.Join(" ", sortedArray));
    }
}