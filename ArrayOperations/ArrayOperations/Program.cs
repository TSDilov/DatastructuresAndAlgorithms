using ArrayOperations;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 0, 1, 3, 12 };
        Console.WriteLine(ArrayOperation.ContainsDuplicates(array));
        Console.WriteLine(string.Join(" ", array));
    }
}