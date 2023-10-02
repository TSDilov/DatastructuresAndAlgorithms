using ArrayOperations;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 1, 3, 5, 6, 10, 15 };
        int[] arrray2 = { 2, 4,1, 14 };
        var element = ArrayOperation.MergeArrays(array, arrray2);
        Console.WriteLine(string.Join(" ", element));
    }
}