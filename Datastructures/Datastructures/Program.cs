using Datastructures.BinarySearchTree;
using Datastructures.Stack;

internal class Program
{
    private static void Main(string[] args)
    {
        var stack = new CustomStack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        foreach (var item in stack) 
        {
            Console.WriteLine(item);
        }
        var reverseStack = stack.Reverse();
        foreach (var item in reverseStack)
        {
            Console.WriteLine(item);
        }
    }
}