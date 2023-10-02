using ArrayOperations;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 2, 2, 2 };
        var element = ArrayOperation.GetMajorityElement(array);
        Console.WriteLine(element);
    }
}