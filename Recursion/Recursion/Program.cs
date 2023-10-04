using Recursion;
using Recursion.DataTypes;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] unsortedArray = { 5, 2, 9, 1, 5, 6, 3 };
        int target = 11;

        int result = OperationWithRecursion.BinarySearch(unsortedArray, target);
        Console.WriteLine(result);
    }
}