using ArrayOperations;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        Console.WriteLine(ArrayOperation.FindMatchingPairsThatSumTheLookingInt(array, 9));

    }
}