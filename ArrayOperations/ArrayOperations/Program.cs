using ArrayOperations;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        ArrayOperation.ReverseArray(array);
        Console.WriteLine(string.Join(" ", array));
    }
}