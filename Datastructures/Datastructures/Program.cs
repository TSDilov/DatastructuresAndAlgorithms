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
        tree.Insert(6);
        tree.Insert(17);
        tree.PostOrder();
        tree.Delete(15);
        Console.WriteLine();
        tree.PostOrder();
        
    }
}