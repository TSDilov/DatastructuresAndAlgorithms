using ArrayOperations;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 0, 1, 0, 3, 12 };
        ArrayOperation.Move(array);
        Console.WriteLine(string.Join(" ", array));
    }
}