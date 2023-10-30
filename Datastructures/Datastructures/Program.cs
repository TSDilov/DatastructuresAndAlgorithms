using Datastructures.BinarySearchTree;

internal class Program
{
    private static void Main(string[] args)
    {
        var tree = new BinarySearchTree<int>();
        tree.Insert(15);
        tree.Insert(20);
        tree.Insert(5);
        tree.Insert(25);
        tree.Insert(3);
        tree.InOrderPrint();
        tree.Delete(3);
        Console.WriteLine();
        tree.InOrderPrint();
    }
}